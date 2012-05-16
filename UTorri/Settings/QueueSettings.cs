namespace UTorri.Settings
{
    /// <summary>
    /// Queueing-oriented settings container.
    /// </summary>
    public class QueueSettings : SettingsBase
    {
        public bool DontCountSlowDownload
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.queueDontCountSlowDownload];
            }
            set
            {
                _parent[AppSettingsKeys.queueDontCountSlowDownload] = value;
            }
        }

        public bool DontCountSlowUpload
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.queueDontCountSlowUpload];
            }
            set
            {
                _parent[AppSettingsKeys.queueDontCountSlowUpload] = value;
            }
        }

        public bool UseSeedPeerRatio
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.queueUseSeedPeerRatio];
            }
            set
            {
                _parent[AppSettingsKeys.queueUseSeedPeerRatio] = value;
            }
        }

        public bool NoSeedsPriority
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.queuePrioNoSeeds];
            }
            set
            {
                _parent[AppSettingsKeys.queuePrioNoSeeds] = value;
            }
        }

        public int SlowDownloadThreshold
        {
            get
            {
                return (int)_parent[AppSettingsKeys.queueSlowDownloadTreshold];
            }
            set
            {
                _parent[AppSettingsKeys.queueSlowDownloadTreshold] = value;
            }
        }

        public int SlowUploadThreshold
        {
            get
            {
                return (int)_parent[AppSettingsKeys.queueSlowUploadTreshold];
            }
            set
            {
                _parent[AppSettingsKeys.queueSlowUploadTreshold] = value;
            }
        }
        protected QueueSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
