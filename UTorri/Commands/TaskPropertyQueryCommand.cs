using System.Collections.Generic;
using System.Linq;

namespace UTorri.Commands
{
    /// <summary>
    /// Class used for getting and setting torrent task properties.
    /// </summary>
    public class TaskPropertyQueryCommand : QueryCommand
    {
        private const string GetActionName = "?action=getprops";
        private const string SetActionName = "?action=setprops";

        /// <summary>
        /// Creates a QueryCommand request for getting torrents tasks properties.
        /// </summary>
        /// <param name="torrents"></param>
        public TaskPropertyQueryCommand(params Torrent[] torrents)
            :base(GetActionName,CommandType.Action)
        {
            Parameters = torrents
                .Select(t => new KeyValuePair<string, string>("hash", t.Hash));
        }

        /// <summary>
        /// Creates a QueryCommand request for setting specyfic task properties.
        /// Change sets are saved as they were during constructor call.
        /// </summary>
        /// <param name="torrentTasks"></param>
        public TaskPropertyQueryCommand(params TorrentJobProperties[] torrentTasks)
            :base(SetActionName, CommandType.Action)
        {
            var list = new List<KeyValuePair<string, string>>();
            foreach (var task in torrentTasks)
            {
                var keyvalues = CreateQueryString(task);
                list.AddRange(keyvalues);
            }
            Parameters = list;
        }

        /// <summary>
        /// Creates a query string fragment responsible for sending changing set data of target task.
        /// </summary>
        /// <param name="task"></param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string ,string >> CreateQueryString(TorrentJobProperties task)
        {
            return new[] {new KeyValuePair<string, string>("hash", task.Hash)}
                .Union(task.Changes);
        }
    }
}
