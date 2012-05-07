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
        public string Checksum { get; set; }
        
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
        public int Received { get; set; }

        /// <summary>
        /// Number of bytes sent.
        /// </summary>
        public int Sent { get; set; }

        /// <summary>
        /// Torrent ratio.
        /// </summary>
        public double Ratio { get; set; }

        /// <summary>
        /// Sending speed of current torrent.
        /// </summary>
        public int SendingSpeed { get; set; }

        /// <summary>
        /// Receiving speed of current torrent.
        /// </summary>
        public int ReceiveSpeed { get; set; }

        /// <summary>
        /// Estimated time to finish downloading.
        /// </summary>
        public TimeSpan EstimatedFinish { get; set; }

        /// <summary>
        /// Torrent's label.
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// Number of peers connected.
        /// </summary>
        public int ConnectedPeerCount { get; set; }

        /// <summary>
        /// Number of seeds connected.
        /// </summary>
        public int ConnectedSeedCount { get; set; }

        /// <summary>
        /// Number of peers waiting in queue.
        /// </summary>
        public int QueuedPeerCount { get; set; }

        /// <summary>
        /// Number of seed waiting in queue.
        /// </summary>
        public int QueuedSeedCount { get; set; }

        /// <summary>
        /// Percent Availability.
        /// </summary>
        public double Availability { get; set; }

        /// <summary>
        /// Position in torrents queue.
        /// </summary>
        public int ScheduledPosition { get; set; }

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
            Checksum = array[0].ToString();
            Status = (TorrentStatus)((int)(long)array[1]);
            Name = array[2].ToString();
            Size = (int)(long)array[3];
            Progress = ((long) array[4])/10.0;
            Received = (int)(long)array[5];
            Sent = (int)(long)array[6];
            Ratio = ((long)array[7])/10.0;
            SendingSpeed = (int)(long)array[8];
            ReceiveSpeed = (int)(long)array[9];

            var sec = (int)(long)array[10];
            EstimatedFinish = sec != -1
                                  ? TimeSpan.FromSeconds((int)(long)array[10])
                                  : TimeSpan.Zero;
            Label = array[11].ToString();
            ConnectedPeerCount = (int)(long)array[12];
            QueuedPeerCount = (int)(long)array[13];
            ConnectedSeedCount = (int)(long)array[14];
            QueuedPeerCount = (int)(long)array[15];
            Availability = ((long) array[16])/65355.0;
            ScheduledPosition = (int)(long)array[17];
            Remaining = (int)(long)array[18];
        }

        /// <summary>
        /// Fill actual properties from passed json object.
        /// </summary>
        /// <param name="json"></param>
        public void FromJson(string json)
        {
            var tab = JsonConvert.DeserializeObject<ICollection<string>>(json).ToArray();
            Checksum = tab[0];
            Status = (TorrentStatus)int.Parse(tab[1]);
            Name = tab[2];
            Size = int.Parse(tab[3]);
            Progress = double.Parse(tab[4]) * 1000.0;
            Received = int.Parse(tab[5]);
            Sent = int.Parse(tab[6]);
            Ratio = double.Parse(tab[7]) * 1000.0;
            SendingSpeed = int.Parse(tab[8]);
            ReceiveSpeed = int.Parse(tab[9]);
            EstimatedFinish = TimeSpan.FromSeconds(int.Parse(tab[10]));
            Label = tab[11];
            ConnectedPeerCount = int.Parse(tab[12]);
            QueuedPeerCount = int.Parse(tab[13]);
            ConnectedSeedCount = int.Parse(tab[14]);
            QueuedSeedCount = int.Parse(tab[15]);
            Availability = float.Parse(tab[16]) * 65355 ;
            ScheduledPosition = int.Parse(tab[17]);
            Remaining = int.Parse(tab[18]);
        }

        public static bool operator ==(Torrent first, Torrent second)
        {
            return first.Checksum == second.Checksum;
        }

        public static bool operator !=(Torrent first, Torrent second)
        {
            return first.Checksum != second.Checksum;
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
