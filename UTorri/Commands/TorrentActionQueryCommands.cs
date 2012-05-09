using System.Collections.Generic;
using System.Linq;

namespace UTorri.Commands
{
    /// <summary>
    /// Base class for all types of torrent action query commands.
    /// </summary>
    public class TorrentActionQueryCommand : QueryCommand
    {
        public TorrentActionQueryCommand(string action, params Torrent[] torrents)
            : base(action, CommandType.Action)
        {
            Parameters = torrents
                .Select(t => new KeyValuePair<string, string>("hash", t.Hash));
        }
    }

    /// <summary>
    /// QueryCommand for stop torrent request.
    /// </summary>
    public class StopQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionStop = "?action=stop";

        /// <summary>
        /// Creates new instance of StopQueryCommand for specified torrents.
        /// </summary>
        /// <param name="torrents"></param>
        public StopQueryCommand(params Torrent[] torrents) : base(ActionStop, torrents) { }
    }

    /// <summary>
    /// QueryCommand class for start (or forced start) torrent request.
    /// </summary>
    public class StartQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionStart = "?action=start";
        private const string ActionForceStart = "?action=forcestart";

        /// <summary>
        /// Creates new instance of StartQueryCommand object for specified torrents.
        /// </summary>
        /// <param name="forcestart">Force start request.</param>
        /// <param name="torrents"></param>
        public StartQueryCommand(bool forcestart, params Torrent[] torrents)
            : base(forcestart ? ActionForceStart : ActionStart, torrents) { }
    }

    /// <summary>
    /// QueryCommand class for pause torrent request.
    /// </summary>
    public class PauseQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionPause = "?action=pause";
        /// <summary>
        /// Creates new instance of PauseQueryCommand object for specified torrents.
        /// </summary>
        /// <param name="torrents"></param>
        public PauseQueryCommand(params Torrent[] torrents) : base(ActionPause, torrents) { }
    }

    /// <summary>
    /// QueryCommand class for unpause torrent request.
    /// </summary>
    public class UnpauseQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionUnpause = "?action=unpause";

        /// <summary>
        /// Creates new instance of UnpauseQueryCommand object for specified torrents.
        /// </summary>
        /// <param name="torrents"></param>
        public UnpauseQueryCommand(params Torrent[] torrents) : base(ActionUnpause, torrents) { }
    }

    /// <summary>
    /// QueryCommand class for rechcek torrents content request.
    /// </summary>
    public class RecheckQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionRecheck = "?action=recheck";

        /// <summary>
        /// Creates new instance of RecheckQueryCommand object for specified torrents.
        /// </summary>
        /// <param name="torrents"></param>
        public RecheckQueryCommand(params Torrent[] torrents) : base(ActionRecheck,torrents) { }
    }

    /// <summary>
    /// QueryCommand class for remove (with downloaded data optionaly) torrent request.
    /// </summary>
    public class RemoveQueryCommand : TorrentActionQueryCommand
    {
        private const string ActionRemove = "?action=remove";
        private const string ActionRemoveData = "?action=removedata";

        /// <summary>
        /// Creates new instance of RemoveQueryCommand object for specified torrents.
        /// </summary>
        /// <param name="withData">Flag which determines if downloaded data should be removed too.</param>
        /// <param name="torrents"></param>
        public RemoveQueryCommand(bool withData, params Torrent[] torrents)
            : base(withData ? ActionRemoveData : ActionRemove, torrents) { }
    }
}