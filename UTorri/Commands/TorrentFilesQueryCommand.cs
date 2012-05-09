using System.Collections.Generic;
using System.Linq;

namespace UTorri.Commands
{
    /// <summary>
    /// QueryCommand object for request of torrent files info.
    /// </summary>
    public class TorrentFilesQueryCommand : QueryCommand
    {
        private const string ActionName = "?action=getfiles";

        /// <summary>
        /// Gets torrents associated with current query command.
        /// </summary>
        public Torrent[] AssociatedTorrents { get; private set; }

        /// <summary>
        /// Creates new QueryCommand instance for specyfic torrents files infos.
        /// </summary>
        /// <param name="torrents"></param>
        public TorrentFilesQueryCommand(params Torrent[] torrents)
            :base(ActionName,CommandType.Action)
        {
            AssociatedTorrents = torrents;
            Parameters = torrents
                .Select(t => new KeyValuePair<string, string>("hash", t.Hash));
        }
    }
}
