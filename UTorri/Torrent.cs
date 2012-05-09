using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace UTorri
{
    /// <summary>
    /// Single torrent representation.
    /// </summary>
    public class Torrent : IJsonFillable
    {
        /// <summary>
        /// Checksum of target torrent.
        /// </summary>
        public string Hash { get; set; }
        
        /// <summary>
        /// Status of target torrent.
        /// </summary>
        public TorrentStatus Status { get; set; }

        /// <summary>
        /// Name of target torrent.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Torrent size, in bytes.
        /// </summary>
        public int Size { get; set; }

        /// <summary>
        /// Percent downloaded size.
        /// </summary>
        public double Progress { get; set; }

        /// <summary>
        /// Number of bytes received.
        /// </summary>
        public int Downloaded { get; set; }

        /// <summary>
        /// Number of bytes sent.
        /// </summary>
        public int Uploaded { get; set; }

        /// <summary>
        /// Torrent ratio.
        /// </summary>
        public double Ratio { get; set; }

        /// <summary>
        /// Sending speed of current torrent.
        /// </summary>
        public int UploadSpeed { get; set; }

        /// <summary>
        /// Receiving speed of current torrent.
        /// </summary>
        public int DownloadSpeed { get; set; }

        /// <summary>
        /// Estimated time to finish downloading.
        /// </summary>
        public TimeSpan Eta { get; set; }

        /// <summary>
        /// Torrent's label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Number of peers connected.
        /// </summary>
        public int PeersConnected { get; set; }

        /// <summary>
        /// Number of seeds connected.
        /// </summary>
        public int SeedsConnected { get; set; }

        /// <summary>
        /// Number of peers waiting in queue.
        /// </summary>
        public int PeersInSwarm { get; set; }

        /// <summary>
        /// Number of seed waiting in queue.
        /// </summary>
        public int SeedsInSwarm { get; set; }

        /// <summary>
        /// Percent Availability.
        /// </summary>
        public double Availability { get; set; }

        /// <summary>
        /// Position in torrents queue.
        /// </summary>
        public int QueueOrder { get; set; }

        /// <summary>
        /// Remaining number of bytes to receive.
        /// </summary>
        public int Remaining { get; set; }

        public Torrent()
        {
            
        }

        public Torrent(IEnumerable<object> parsed)
        {
            var array = parsed.ToArray();
            Hash = array[0].ToString();
            Status = (TorrentStatus)((int)(long)array[1]);
            Name = array[2].ToString();
            Size = (int)(long)array[3];
            Progress = ((long) array[4])/10.0;
            Downloaded = (int)(long)array[5];
            Uploaded = (int)(long)array[6];
            Ratio = ((long)array[7])/10.0;
            UploadSpeed = (int)(long)array[8];
            DownloadSpeed = (int)(long)array[9];

            var sec = (int)(long)array[10];
            Eta = sec != -1
                                  ? TimeSpan.FromSeconds((int)(long)array[10])
                                  : TimeSpan.Zero;
            Label = array[11].ToString();
            PeersConnected = (int)(long)array[12];
            PeersInSwarm = (int)(long)array[13];
            SeedsConnected = (int)(long)array[14];
            PeersInSwarm = (int)(long)array[15];
            Availability = ((long) array[16])/65355.0;
            QueueOrder = (int)(long)array[17];
            Remaining = (int)(long)array[18];
        }

        /// <summary>
        /// Fill actual properties from passed json object.
        /// </summary>
        /// <param name="json"></param>
        public void FromJson(string json)
        {
            var tab = JsonConvert.DeserializeObject<ICollection<string>>(json).ToArray();
            Hash = tab[0];
            Status = (TorrentStatus)int.Parse(tab[1]);
            Name = tab[2];
            Size = int.Parse(tab[3]);
            Progress = double.Parse(tab[4]) * 1000.0;
            Downloaded = int.Parse(tab[5]);
            Uploaded = int.Parse(tab[6]);
            Ratio = double.Parse(tab[7]) * 1000.0;
            UploadSpeed = int.Parse(tab[8]);
            DownloadSpeed = int.Parse(tab[9]);
            Eta = TimeSpan.FromSeconds(int.Parse(tab[10]));
            Label = tab[11];
            PeersConnected = int.Parse(tab[12]);
            PeersInSwarm = int.Parse(tab[13]);
            SeedsConnected = int.Parse(tab[14]);
            SeedsInSwarm = int.Parse(tab[15]);
            Availability = float.Parse(tab[16]) * 65355 ;
            QueueOrder = int.Parse(tab[17]);
            Remaining = int.Parse(tab[18]);
        }

        public static bool operator ==(Torrent first, Torrent second)
        {
            return first.Hash == second.Hash;
        }

        public static bool operator !=(Torrent first, Torrent second)
        {
            return first.Hash != second.Hash;
        }

        public override bool Equals(object obj)
        {
            if(obj is Torrent){ 
                return this == (Torrent)obj;
            }else{
                return base.Equals(obj);
            }
        }
    }

    /// <summary>
    /// Enum representing actual status of associated torrent.
    /// </summary>
    [Flags]
    public enum TorrentStatus
    {
        Started = 1,
        Checking = 2,
        StartAfterCheck = 4,
        Checked = 8,
        Error = 16,
        Suspended = 32,
        Scheduled = 64,
        Loaded = 128
    }
}
