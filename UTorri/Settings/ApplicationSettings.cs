using System.Collections.Generic;
using Newtonsoft.Json;

namespace UTorri.Settings
{
    /// <summary>
    /// Application settings collection.
    /// </summary>
    public class ApplicationSettings: RequestResult, ISettings
    {
        private readonly IDictionary<string, object> _dictionary = new Dictionary<string, object>();
        private readonly IDictionary<string, object> _changeset = new Dictionary<string, object>();
        /// <summary>
        /// Gets changeset since last remote application set.
        /// </summary>
        public IDictionary<string, object> Changeset { get { return _changeset; } }

        /// <summary>
        /// Gets build version.
        /// </summary>
        public int Build { get; protected set; }

        /// <summary>
        /// Queueing oriented settings.
        /// </summary>
        public QueueSettings Queue { get; private set; }

        /// <summary>
        /// Disk input/output oriented settings.
        /// </summary>
        public DiskIOSettings DiskIO { get; set; }

        /// <summary>
        /// Seeds oriented settings.
        /// </summary>
        public SeedSettings Seed { get; set; }

        /// <summary>
        /// Peers oriented settings.
        /// </summary>
        public PeerSettings Peer { get; set; }

        /// <summary>
        /// Bit torrent protocol oriented settings.
        /// </summary>
        public BitTorrentSettings BitTorrent { get; set; }

        /// <summary>
        /// Net connection oriented settings.
        /// </summary>
        public NetSettings Net { get; set; }

        /// <summary>
        /// Statistics oriented settings.
        /// </summary>
        public StatsSettings Statistics { get; set; }

        /// <summary>
        /// uTorrent Graphic User Interface oriented settings.
        /// </summary>
        public GuiSettings Gui { get; set; }

        /// <summary>
        /// Internet service providing oriented settings.
        /// </summary>
        public IspSettings Isp { get; set; }

        /// <summary>
        /// Scheduling oriented settings.
        /// </summary>
        public SchedulingSettings Scheduling { get; set; }

        /// <summary>
        /// Data display oriented settings.
        /// </summary>
        public ShowSettings Show { get; set; }

        /// <summary>
        /// uTorrent Web UI oriented settings.
        /// </summary>
        public WebuiSettings Webui { get; set; }

        /// <summary>
        /// Streaming oriented settings.
        /// </summary>
        public StreamingSettings Streaming { get; set; }

        /// <summary>
        /// Directory oriented settings.
        /// </summary>
        public DirectorySettings Directory { get; set; }

        /// <summary>
        /// Transfer oriented settings.
        /// </summary>
        public MultidayTransferSettings Transfer { get; set; }

        public ApplicationSettings()
        {
            Queue = new QueueSettings(this);
            BitTorrent = new BitTorrentSettings(this);
            DiskIO = new DiskIOSettings(this);
            Seed = new SeedSettings(this);
            Peer = new PeerSettings(this);
            Net = new NetSettings(this);
            Statistics = new StatsSettings(this);
            Gui = new GuiSettings(this);
            Isp = new IspSettings(this);
            Scheduling = new SchedulingSettings(this);
            Show = new ShowSettings(this);
            Webui = new WebuiSettings(this);
            Streaming = new StreamingSettings(this);
            Directory = new DirectorySettings(this);
            Transfer = new MultidayTransferSettings(this);
        }

        public override void FromJson(string json)
        {
            var parsed = JsonConvert.DeserializeObject<AppSettingsJson>(json);
            Build = parsed.build;
            foreach (var setting in parsed.settings)
            {
                SetValue(setting);
            }
        }

        public object this[string index]
        {
            get
            {
                return _dictionary.ContainsKey(index) ? _dictionary[index] : null;
            }
            set
            {
                if (_dictionary.ContainsKey(index))
                    _dictionary[index] = value;
                _dictionary.Add(index, value);

                if (_changeset.ContainsKey(index))
                    _changeset[index] = value;
                _changeset.Add(index, value);
            }
        }

        /// <summary>
        /// Class used for application settings json parsing.
        /// </summary>
        public class AppSettingsJson
        {
            public int build;
            public ICollection<object[]> settings;
        }

        /// <summary>
        /// Set single key-value pair based on parsed array.
        /// </summary>
        /// <param name="array"></param>
        public void SetValue(object[] array)
        {
            var key = array[0].ToString();
            var type = (int)array[1];
            object value = null;
            switch (type)
            {
                case 0:
                    value = int.Parse(array[2].ToString()); break;
                case 1:
                    value = bool.Parse(array[2].ToString()); break;
                case 2:
                    value = array[2].ToString();break;
            }
            if (_dictionary.ContainsKey(key))
                _dictionary[key] = value;
            _dictionary.Add(key, value);
        }
    }
}
