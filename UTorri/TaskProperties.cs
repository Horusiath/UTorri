using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace UTorri
{
    /// <summary>
    /// Torrent task properties class.
    /// </summary>
    public class TaskProperties : RequestResult
    {
        private IDictionary<string, string> _changedValues;
        /// <summary>
        /// Return dictionary with changes made on current task properties.
        /// </summary>
        public IDictionary<string,string> Changes
        {
            get
            {
                return _changedValues;
            }
        }

        /// <summary>
        /// Checksum identifier of associated torrent.
        /// </summary>
        public string Checksum { get; private set; }

        private ICollection<string> _trackers;
        /// <summary>
        /// Gets or sets collection of tracker names.
        /// </summary>
        public ICollection<string> Trackers
        {
            get { return _trackers; }
            set
            {
                _trackers = value;
                ChangeValue("trackers", string.Join("\r\n", _trackers.ToArray()));
            }
        }

        private int _uploadLimit;
        /// <summary>
        /// Gets or sets maximum upload limit.
        /// </summary>
        public int UploadLimit
        {
            get { return _uploadLimit; }
            set
            {
                _uploadLimit = value;
                ChangeValue("ulrate", _uploadLimit.ToString());
            }   
        }

        private int _downloadLimit;
        /// <summary>
        /// Gets or sets maximum download limit.
        /// </summary>
        public int DownloadLimit
        {
            get { return _downloadLimit; }
            set
            {
                _downloadLimit = value;
                ChangeValue("dlrate", _downloadLimit.ToString());
            }
        }

        private TaskPropertyState _startSeeding;
        /// <summary>
        /// Gets or sets Super-Seeding/Initial seeding option.
        /// </summary>
        public TaskPropertyState StartSeeding
        {
            get { return _startSeeding; }
            set
            {
                _startSeeding = value;
                ChangeValue("superseed", ((int)_startSeeding).ToString());
            }
        }

        private TaskPropertyState _dht;
        /// <summary>
        /// Gets or sets Distributed Hash Table usage option.
        /// </summary>
        public TaskPropertyState Dht
        {
            get { return _dht; }
            set
            {
                _dht = value;
                ChangeValue("dht", ((int)_dht).ToString());
            }
        }

        private TaskPropertyState _pex;
        /// <summary>
        /// Gets or sets Peer Exchange Protocol usage option.
        /// </summary>
        public TaskPropertyState Pex
        {
            get { return _pex; }
            set
            {
                _pex = value;
                ChangeValue("pex", ((int)_pex).ToString());
            }
        }

        private TaskPropertyState _seedOverride;
        /// <summary>
        /// Gets or sets seed override option.
        /// </summary>
        public TaskPropertyState SeedOverride
        {
            get { return _seedOverride; }
            set
            {
                _seedOverride = value;
                ChangeValue("seed_override", ((int)_seedOverride).ToString());
            }
        }

        private TimeSpan _seedRatio;
        /// <summary>
        /// Gets or sets maximum seed ratio.
        /// </summary>
        public TimeSpan SeedRatio
        {
            get { return _seedRatio; }
            set
            {
                _seedRatio = value;
                ChangeValue("seed_ratio", _seedRatio.TotalMilliseconds.ToString());
            }
        }

        private TimeSpan _seedTime;
        /// <summary>
        /// Gets or sets maximum seed time.
        /// </summary>
        public TimeSpan SeedTime
        {
            get { return _seedTime; }
            set
            {
                _seedTime = value;
                ChangeValue("seed_time", _seedTime.TotalSeconds.ToString());
            }
        }

        private int _uploadSlots;
        /// <summary>
        /// Gets or sets maximum number of upload slots.
        /// </summary>
        public int UploadSlots
        {
            get { return _uploadSlots; }
            set
            {
                _uploadSlots = value;
                ChangeValue("ulslots", _uploadSlots.ToString());
            }
        }

        public TaskProperties()
        {
            _changedValues = new Dictionary<string, string>();
        }

        public TaskProperties(string json)
            : this()
        {
            this.FromJson(json);
        }

        /// <summary>
        /// Notifies changes made on any of the torrent task property.
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        protected void ChangeValue(string key, string value)
        {
            if (_changedValues.ContainsKey(key))
                _changedValues[key] = value;
            _changedValues.Add(key,value);
        }

        public override void FromJson(string json)
        {
            var obj = JsonConvert.DeserializeObject<TorrentTaskRawJson>(json);
            this.Checksum = obj.hash;
            this._trackers = obj.trackers.Split(new[] {"\r\n"}, StringSplitOptions.RemoveEmptyEntries);
            this._uploadLimit = obj.ulrate;
            this._downloadLimit = obj.dlrate;
            this._startSeeding = (TaskPropertyState) obj.superseed;
            this._dht = (TaskPropertyState) obj.dht;
            this._pex = (TaskPropertyState) obj.pex;
            this._seedOverride = (TaskPropertyState) obj.seed_override;
            this._seedRatio = TimeSpan.FromMilliseconds(obj.seed_ratio);
            this._seedTime = TimeSpan.FromSeconds(obj.seed_time);
            this._uploadSlots = obj.ulslots;
        }

        /// <summary>
        /// Helper class used for JSON parsing purposes.
        /// </summary>
        internal class TorrentTaskRawJson
        {
            internal string hash;
            internal string trackers;
            internal int ulrate;
            internal int dlrate;
            internal int superseed;
            internal int dht;
            internal int pex;
            internal int seed_override;
            internal int seed_ratio;
            internal int seed_time;
            internal int ulslots;
        }
    }

    /// <summary>
    /// Torrent task property option.
    /// </summary>
    public enum TaskPropertyState
    {
        /// <summary>
        /// Option forbidden.
        /// </summary>
        Forbidden = -1,

        /// <summary>
        /// Option shutdown.
        /// </summary>
        Off = 0,

        /// <summary>
        /// Use option when available.
        /// </summary>
        On = 1
    }
}
