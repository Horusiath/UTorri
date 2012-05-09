using System;
using System.Collections.Generic;
using System.Linq;

namespace UTorri.Commands
{
    /// <summary>
    /// QueryCommand class for handling torrent file priority setting request.
    /// </summary>
    public class PriorityQueryCommand : QueryCommand
    {
        private const string ActionPriority = "?action=setprio";

        public PriorityQueryCommand(FileList fileList)
            : base(ActionPriority, CommandType.Action)
        {
            Parameters = CreateQueryString(fileList.ToArray());
        }

        /// <summary>
        /// Parses a TorrentFile collection changeset into regular KeyValuePair enumerable.
        /// </summary>
        /// <param name="files"></param>
        /// <returns></returns>
        private static IEnumerable<KeyValuePair<string,string >> CreateQueryString(TorrentFile[] files)
        {
            var changed = (from f in files
                           where f.PriorityChanged
                           group f by f.Hash
                           into g
                           select new
                           {
                               Hash = g.Key,
                               Values = g.Select(fl => new 
                               {
                                   Prior = fl.Priority,
                                   Index = Array.IndexOf(files, fl)
                               })
                           });

            var parameters = new List<KeyValuePair<string, string>>();
            foreach (var ch in changed)
            {
                parameters.Add(new KeyValuePair<string, string>("hash",ch.Hash));
                foreach (var value in ch.Values)
                {
                    parameters.Add(
                        new KeyValuePair<string, string>("p",((int)value.Prior).ToString()));
                    parameters.Add(new KeyValuePair<string, string>("f",value.Index.ToString()));
                }
            }
            return parameters;
        }
    }
}
