using System;
using System.Net;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using UTorri.Commands;

namespace UTorri.Connection
{
    /// <summary>
    /// Delegate used for handling <see cref="HttpRemoteConnection"/> response callbacks.
    /// </summary>
    /// <param name="response"></param>
    public delegate void HttpRemoteConnectionCallback(string response);

    /// <summary>
    /// Class representing remote connection with uTorrent application.
    /// </summary>
    public class HttpRemoteConnection : IDisposable
    {
        /// <summary>
        /// Regex used to remove all unnecesary sorrounding tags from token response page.
        /// </summary>
        private static readonly Regex tokenRegex =
            new Regex("\\<[^\\>]*\\>", RegexOptions.IgnoreCase | RegexOptions.Multiline | RegexOptions.Compiled);

        /// <summary>
        /// Header template used for torrent file uploading.
        /// </summary>
        private const string headerTemplate = "\r\n--{0}\r\nContent-Disposition: form-data; name=\"torrent\";filename=\"{1}\"\r\nContent-Type:application/x-bittorrent\r\n\r\n";

        /// <summary>
        /// Form item template used for torrent file uploading.
        /// </summary>
        private const string formItemTemplate = "\r\nContent-Disposition: form-data; name=\"torrent\";\r\n\r\n{0}";

        /// <summary>
        /// Logged user credentials.
        /// </summary>
        private NetworkCredential credential;

        /// <summary>
        /// Logged user cookie container.
        /// </summary>
        private CookieContainer cookie;
        
        /// <summary>
        /// Gets or sets remote machine base URL.
        /// </summary>
        public Uri Url { get; set; }

        /// <summary>
        /// Gets or sets timeout used for synchronous request-based operations.
        /// </summary>
        public TimeSpan RequestTimeout { get; set; }

        /// <summary>
        /// Gets value indicating if connection has been established.
        /// </summary>
        public bool IsInitialized { get; private set; }

        /// <summary>
        /// Gets token associated with current remote connection.
        /// </summary>
        public string Token { get; private set; }

        #region Constructors

        /// <summary>
        /// Creates new instance of uTorrent remote connection handler.
        /// </summary>
        /// <param name="url">Remote machine URL address.</param>
        /// <param name="credential">User login credentials.</param>
        public HttpRemoteConnection(Uri url, NetworkCredential credential)
        {
            this.cookie = new CookieContainer();
            this.Url = url;
            this.Token = null;
            this.credential = credential;
            this.IsInitialized = false;
            this.RequestTimeout = TimeSpan.FromSeconds(30);
        }

        /// <summary>
        /// Creates new instance of uTorrent remote connection handler.
        /// </summary>
        /// <param name="url">Remote machine URL address.</param>
        /// <param name="password">User login password.</param>
        /// <param name="username">User login name.</param>
        public HttpRemoteConnection(Uri url, string username, string password)
            : this(url, new NetworkCredential { Password = password, UserName = username })
        { }

        /// <summary>
        /// Creates new instance of uTorrent remote connection handler.
        /// </summary>
        /// <param name="address">Remote machine DNS name or IP address.</param>
        /// <param name="port">Remote machine uTorrent listening port.</param>
        /// <param name="password">User login password.</param>
        /// <param name="username">User login name.</param>
        public HttpRemoteConnection(string address, int port, string username, string password)
            : this(new Uri(string.Format("http://{0}:{1}/", address, port)),
             new NetworkCredential { Password = password, UserName = username })
        { }

        #endregion

        #region Opening connection methods

        /// <summary>
        /// Tries to establish the connection asynchronously. 
        /// </summary>
        public void OpenAsync(Action callback)
        {
            var req = CreateRequest(new Uri(Url, "/gui/token.html"));
            req.BeginGetResponse((result)=>
            {
                var request = (HttpWebRequest)result.AsyncState;
                using (var response = (HttpWebResponse)request.EndGetResponse(result))
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    var html = reader.ReadToEnd();
                    var token = tokenRegex.Replace(html, string.Empty);

                    if (string.IsNullOrEmpty(token))
                        throw new TokenException("Cannot aquire uTorrent application token. Response page cannot be parsed.");

                    Token = token;
                    IsInitialized = true;
                }
                if (callback != null)
                    callback();
            }, req);
        }

        #endregion

        #region Request handling

        /// <summary>
        /// Executes target QueryCommand via GET request asynchronously and invokes callback when response arrives.
        /// </summary>
        public void GetAsync(QueryCommand command, HttpRemoteConnectionCallback callback)
        {
            AsyncRequest(command, "GET", callback);
        }

        /// <summary>
        /// Executes target AddQueryCommand via POST request asynchronously and invokes callback when response arrives.
        /// </summary>
        public void UploadTorrentAsync(AddQueryCommand command)
        {
            if (string.IsNullOrEmpty(Token) || !IsInitialized)
                throw new TokenException("Token has not been acquired. Use OpenAsync() method to acquire the token.");

            if (string.IsNullOrEmpty(command.TorrentName) || command.TorrentContent == null)
                throw new ArgumentException(
                    "QueryCommand object doesn't containt required file data. Either torrent name or torrent file content weren't found.");

            var query = "/gui/" + command.ToQuery() + "&token=" + Token;
            var req = CreateRequest(new Uri(query), "POST");
            req.AllowAutoRedirect = false;

            // create http boundary
            var boundary = "----------------------------" + DateTime.Now.Ticks.ToString("x");
            req.ContentType = "multipart/form-data; boundary=" + boundary;
            var boundaryBytes = ("\r\n--"+boundary).ToASCII();

            // create http header
            var header = string.Format(headerTemplate, boundary, command.TorrentName);
            var headerBytes = header.ToASCII();

            // create http form item description
            var i = command.TorrentName.LastIndexOf('.');
            var formItemName = i == -1 
                ? command.TorrentName 
                : command.TorrentName.Substring(0, i);
            var formitem = string.Format(formItemTemplate, formItemName);
            var formitembytes = formitem.ToASCII();

            using (var stream = new MemoryStream())
            {
                stream.Write(headerBytes, 0, headerBytes.Length);
                stream.Write(command.TorrentContent, 0, command.TorrentContent.Length);
                stream.Write(boundaryBytes, 0, boundaryBytes.Length);
                stream.Write(formitembytes, 0, formitembytes.Length);
                stream.Write(boundaryBytes, 0, boundaryBytes.Length);

                var data = ResetAndRead(stream);
                req.BeginGetRequestStream(asyncResult =>
                {
                    var request = asyncResult.AsyncState as HttpWebRequest;
                    using (var requestStream = request.EndGetRequestStream(asyncResult))
                    {
                        requestStream.Write(data,0,data.Length);
                        request.BeginGetResponse(null, null);
                    }
                }, req);
            }
        }

        /// <summary>
        /// Reset position of memory stream and returns its content as byte array.
        /// </summary>
        /// <param name="stream"></param>
        /// <returns></returns>
        private byte[] ResetAndRead(MemoryStream stream)
        {
            var tmp = new byte[stream.Length];
            stream.Position = 0;
            stream.Read(tmp, 0, tmp.Length);
            return tmp;
        }

        private void AsyncRequest(QueryCommand command, string method, HttpRemoteConnectionCallback callback)
        {
            if (string.IsNullOrEmpty(Token) || !IsInitialized)
                throw new TokenException("Token has not been acquired. Use OpenAsync() method to acquire the token.");

            var query = "/gui/" + command.ToQuery() + "&token=" + Token;
            var request = CreateRequest(new Uri(Url, query), method);

            var handler = new ManualResetEvent(false);
            var result = string.Empty;

            request.BeginGetResponse((asyncResult) =>
            {
                if (callback != null)
                {
                    var req = (HttpWebRequest) asyncResult.AsyncState;
                    using (var resp = (HttpWebResponse) req.EndGetResponse(asyncResult))
                    using (var reader = new StreamReader(resp.GetResponseStream()))
                    {
                        var data = reader.ReadToEnd();
                        callback(data);
                    }
                }
            }, request);
        }

        /// <summary>
        /// Creates new HttpWebRequest object.
        /// </summary>
        /// <param name="uri">Requested operation (action or list)</param>
        /// <param name="type">Http method type.</param>
        private HttpWebRequest CreateRequest(Uri uri, string type = "GET")
        {
            var request = (HttpWebRequest)WebRequest.CreateHttp(uri);
            request.Method = type;
            request.AllowReadStreamBuffering = false;
            request.CookieContainer = cookie;
            request.Credentials = this.credential;
            return request;
        }

        #endregion

        public void Dispose()
        {
            this.cookie = null;
            this.Token = null;
            this.IsInitialized = false;
        }
    }
}
