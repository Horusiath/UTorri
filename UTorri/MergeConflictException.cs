using System;

namespace UTorri
{
    /// <summary>
    /// Exception type thrown on two TorrentList incompatibility.
    /// </summary>
    public class MergeConflictException :Exception
    {
        public MergeConflictException(string msg) : base(msg) { }
    }
}
