using System;
using System.Collections.Generic;
using System.Net;

namespace UTorri.Commands
{
    /// <summary>
    /// QueryCommand class, which allows to create add torrent requests.
    /// </summary>
    public class AddQueryCommand : QueryCommand
    {
        private const string AddUrl = "?action=add-url";
        private const string AddFile = "?action=add-file";

        /// <summary>
        /// Optional (add file only) torrent file content.
        /// </summary>
        public byte[] TorrentContent { get; set; }

        /// <summary>
        /// Optional (add file only) torrent file name.
        /// </summary>
        public string TorrentName { get; set; }

        /// <summary>
        /// Creates new instance of AddQueryCommand class.
        /// </summary>
        /// <param name="torrentUrl"></param>
        public AddQueryCommand(Uri torrentUrl)
            : base(AddUrl, CommandType.Action,
            new KeyValuePair<string, string>("s", HttpUtility.UrlEncode(torrentUrl.ToString())))
        {
            // TO DO: cookie file support
        }

        /// <summary>
        /// Creates new instance of AddQueryCommand class.
        /// </summary>
        /// <param name="torrentUrl"></param>
        public AddQueryCommand(string torrentUrl)
            : this(new Uri(torrentUrl, UriKind.Absolute))
        { }

        /// <summary>
        /// Creates new instance of AddQueryCommand class for specific torrent file.
        /// </summary>
        /// <param name="torrentName">Torrent file name.</param>
        /// <param name="torrentContent">Torrent file content.</param>
        public AddQueryCommand(string torrentName, byte[] torrentContent)
            : base(AddFile, CommandType.Action)
        {
            TorrentContent = torrentContent;
            TorrentName = torrentName;
        }

    }
}
