using System.Collections.Generic;
using System.Linq;

namespace UTorri
{
    /// <summary>
    /// Single torrent file associated with specific Torrent object.
    /// </summary>
    public class TorrentFile
    {
        /// <summary>
        /// Gets flag determining if Priority property has been changed.
        /// </summary>
        public bool PriorityChanged { get; private set; }

        /// <summary>
        /// Gets checksum identifier of associated torrent.
        /// </summary>
        public string Checksum { get; protected set; }

        /// <summary>
        /// Gets torrent file name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Gets file size.
        /// </summary>
        public int FileSize { get; protected set; }

        /// <summary>
        /// Gets received number of bytes of current file.
        /// </summary>
        public int Received { get; protected set; }

        private Priority _priority;
        /// <summary>
        /// Gets or sets current torrent file priority.
        /// </summary>
        public Priority Priority
        {
            get { return _priority; }
            set
            {
                _priority = value;
                PriorityChanged = true;
            }
        }

        public TorrentFile() { }

        /// <summary>
        /// Creates new instance of torrent file for specified torrent checksum.
        /// </summary>
        /// <param name="checksum"></param>
        public TorrentFile(string checksum)
        {
            this.Checksum = checksum;
        }

        /// <summary>
        /// Creates new instance of torrent file for specified torrent.
        /// </summary>
        /// <param name="parent"></param>
        public TorrentFile(Torrent parent) : this(parent.Checksum)
        {
        }

        /// <summary>
        /// Fills current torrent file with specified data (received through JSON parsing).
        /// </summary>
        /// <param name="data"></param>
        internal void FillData(IEnumerable<object> data)
        {
            var array = data.ToArray();
            Name = array[0].ToString();
            FileSize = (int) array[1];
            Received = (int) array[2];
            _priority = (Priority) array[3];
        }
    }

    /// <summary>
    /// Torrent file priority.
    /// </summary>
    public enum Priority : byte
    {
        /// <summary>
        /// File download is forbidden.
        /// </summary>
        DontDownload = 0,

        /// <summary>
        /// File download has low priority.
        /// </summary>
        Low = 1,

        /// <summary>
        /// File download has standard priority.
        /// </summary>
        Normal = 2,

        /// <summary>
        /// File download has high priority.
        /// </summary>
        High = 3
    }
}
