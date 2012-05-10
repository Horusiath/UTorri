using System;
using System.Net;
using UTorri.Commands;
using UTorri.Connection;

namespace UTorri.Client
{
    /// <summary>
    /// Delegate type used by RemoteClient events.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="args"></param>
    public delegate void RemoteClientResponseHandler(object sender, RemoteClientResponseEventArgs args);

    /// <summary>
    /// Wrapper class on HttpConnection, which simplify remote operations.
    /// </summary>
    public class RemoteClient : IDisposable
    {
        /// <summary>
        /// Gets or sets underlying connection object.
        /// </summary>
        public HttpRemoteConnection Connection { get; set; }

        /// <summary>
        /// Gets or sets factory object responsible for converting json responses
        /// into valid RequestResponse objects.
        /// </summary>
        public RequestResultFactory ResponseFactory { get; set; }

        /// <summary>
        /// Gets flag determining if current client connection has been opened.
        /// </summary>
        public bool IsOpened { get { return Connection != null && Connection.IsInitialized; } }

        /// <summary>
        /// Event fired when connection has been opened.
        /// </summary>
        public event RemoteClientResponseHandler ConnectionOpened;

        /// <summary>
        /// Event fired on http response received.
        /// </summary>
        public event RemoteClientResponseHandler ResponseArrived;

        #region Constructors

        /// <summary>
        /// Creates new instance of RemoteClient.
        /// </summary>
        /// <param name="address">Absolute uri used for remote connection.</param>
        /// <param name="credential">Credentials used for authorization process.</param>
        public RemoteClient(Uri address, NetworkCredential credential)
        {
            Connection = new HttpRemoteConnection(address, credential);
            ResponseFactory = RequestResultFactory.Create();
        }

        /// <summary>
        /// Creates new instance of RemoteClient.
        /// </summary>
        /// <param name="address">Address of machine (egz. 127.0.0.1 or localhost)</param>
        /// <param name="port">Listening port of target machine uTorrent application</param>
        /// <param name="username">Authorized username</param>
        /// <param name="password">Authorized password</param>
        public RemoteClient(string address, int port, string username, string password)
            : this(new Uri(string.Format("http://{0}:{1}", address, port)),
                new NetworkCredential(username, password))
        { }

        /// <summary>
        /// Creates new instance of RemoteClient.
        /// </summary>
        /// <param name="address">Absolute uri used for remote connection.</param>
        /// <param name="username">Authorized username</param>
        /// <param name="password">Authorized password</param>
        public RemoteClient(Uri address, string username, string password)
            : this(address, new NetworkCredential(username, password))
        { }

        #endregion

        /// <summary>
        /// Performs asynchronous open action. ConnectionOpened event will be raised
        /// when opening will complete successfuly.
        /// </summary>
        public void OpenAsync()
        {
            Connection.OpenAsync(()=>
            {
                if (Connection.IsInitialized && ConnectionOpened != null)
                    ConnectionOpened(this, new RemoteClientResponseEventArgs(Connection.Token, null));
            });
        }

        #region RequestMethods

        /// <summary>
        /// Creates asynchronous request for torrent list.
        /// </summary>
        /// <param name="callback">Callback method invoked when response arrives.</param>
        public void GetTorrentList(Action<TorrentList> callback)
        {
            var command = new TorrentListQueryCommand();
            Connection.GetAsync(command,(json)=>
            {
                var res = ResponseFactory.Get<TorrentList>(json);
                HandleResponse(json, res);
                callback(res);
            });
        }

        /// <summary>
        /// Creates asynchronous request for continuation (or refreshing) of target torrent list.
        /// </summary>
        /// <param name="callback">Callback method with continuation torrent list.</param>
        /// <param name="continued">Torrent list, which continuation should be received.</param>
        public void GetTorrentList(Action<TorrentList> callback, TorrentList continued)
        {
            var command = new TorrentListQueryCommand(continued);
            Connection.GetAsync(command, (json)=>
            {
                var res = ResponseFactory.Get<TorrentList>(json);
                HandleResponse(json, res);
                callback(res);
            });
        }

        /// <summary>
        /// Creates asynchronous request for target torrents files.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="torrents"></param>
        public void GetTorrentFiles(Action<TorrentFileList> callback, params Torrent[] torrents)
        {
            var command = new TorrentFilesQueryCommand(torrents);
            Connection.GetAsync(command, (json)=>
                                             {
                                                 var res = ResponseFactory.Get<TorrentFileList>(json);
                                                 HandleResponse(json, res);
                                                 callback(res);
                                             });
        }

        /// <summary>
        /// Creates asynchronous request for target torrents properties.
        /// </summary>
        /// <param name="callback"></param>
        /// <param name="torrents"></param>
        public void GetTorrentProperties(Action<TorrentJobProperties> callback,
            params Torrent[] torrents)
        {
            var command = new TaskPropertyQueryCommand(torrents);
            Connection.GetAsync(command, (json)=>
            {
                var res = ResponseFactory.Get<TorrentJobProperties>(json);
                HandleResponse(json, res);
                callback(res);
            });
        }

        /// <summary>
        /// Creates asynchronous request for setting target torrents properties.
        /// </summary>
        /// <param name="properties"></param>
        public void SetTorrentProperties(params TorrentJobProperties[] properties)
        {
            var command = new TaskPropertyQueryCommand(properties);
            Connection.GetAsync(command, null);
        }

        /// <summary>
        /// Starts target torrents remotely.
        /// </summary>
        /// <param name="forcestart">Enforces torrents start</param>
        /// <param name="torrents"></param>
        public void StartTorrents(bool forcestart, params Torrent[] torrents)
        {
            var command = new StartQueryCommand(forcestart, torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Stops target torrents remotely
        /// </summary>
        /// <param name="torrents"></param>
        public void StopTorrents(params Torrent[] torrents)
        {
            var command = new StopQueryCommand(torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Pauses target torrents remotely.
        /// </summary>
        /// <param name="torrents"></param>
        public void PauseTorrents(params Torrent[] torrents)
        {
            var command = new PauseQueryCommand(torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Unpauses target torrents remotely.
        /// </summary>
        /// <param name="torrents"></param>
        public void UnpauseTorrens(params Torrent[] torrents)
        {
            var command = new UnpauseQueryCommand(torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Rechecks target torrents remotely.
        /// </summary>
        /// <param name="torrents"></param>
        public void RecheckTorrents(params Torrent[] torrents)
        {
            var command = new RecheckQueryCommand(torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Removes target torrents remotely.
        /// </summary>
        /// <param name="withData">Also removes from disk data downloaded using target torrents.</param>
        /// <param name="torrents"></param>
        public void RemoveTorrents(bool withData, params Torrent[] torrents)
        {
            var command = new RemoveQueryCommand(withData, torrents);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Set torrent priorities passed by target FileList object.
        /// </summary>
        /// <param name="list"></param>
        public void SetTorrentPriority(TorrentFileList list)
        {
            var command = new PriorityQueryCommand(list);
            Connection.GetAsync(command,null);
        }

        /// <summary>
        /// Add torrent from target url address.
        /// </summary>
        /// <param name="url"></param>
        public void AddTorrent(Uri url)
        {
            var command = new AddQueryCommand(url);
            Connection.GetAsync(command, null);
        }

        /// <summary>
        /// Add torrent from file.
        /// </summary>
        /// <param name="fileName">Torrent file name.</param>
        /// <param name="fileContent">Torrent file content.</param>
        public void AddTorrent(string fileName, byte[] fileContent)
        {
            var command = new AddQueryCommand(fileName, fileContent);
            Connection.UploadTorrentAsync(command);
        }

        /// <summary>
        /// Handle response and fire event.
        /// </summary>
        /// <param name="json">Raw response string.</param>
        /// <param name="res">Parsed request result object.</param>
        private void HandleResponse<T>(string json, T res) where T: RequestResult
        {
            if (ResponseArrived != null)
            {
                var args = new RemoteClientResponseEventArgs(res, json);
                ResponseArrived(this, args);
            }
        }

        #endregion

        public void Dispose()
        {
            Connection.Dispose();
        }
    }
}
