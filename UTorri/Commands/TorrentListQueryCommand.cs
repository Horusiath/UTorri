using System.Collections.Generic;

namespace UTorri.Commands
{
    /// <summary>
    /// QueryCommand derivative which allows to create request 
    /// for list of torrents.
    /// </summary>
    public class TorrentListQueryCommand : QueryCommand
    {
        private const string ListQuery = "?list=1";

        /// <summary>
        /// Gets optional continuation list buffer identity.
        /// </summary>
        public long? ContinuationListIdentity { get; private set; }

        /// <summary>
        /// Creates new instance of get list request query command.
        /// </summary>
        public TorrentListQueryCommand() : base(ListQuery, CommandType.List) { }

        /// <summary>
        /// Creates continuation instance of get list request query command.
        /// </summary>
        /// <param name="list">List object, on which conntinuation request will be based.</param>
        public TorrentListQueryCommand(TorrentList list): base(ListQuery, CommandType.List, 
                new KeyValuePair<string, string>("cid",list.BufferIdentity.ToString()))
        {
            ContinuationListIdentity = list.BufferIdentity;
        }
    }
}
