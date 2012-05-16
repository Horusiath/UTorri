namespace UTorri.Settings
{
    /// <summary>
    /// Scheduling-oriented setting container.
    /// </summary>
    public class SchedulingSettings : SettingsBase
    {
        public bool Enable
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.schedEnable];
            }
            set
            {
                _parent[AppSettingsKeys.schedEnable] = value;
            }
        }

        public int UploadRate
        {
            get
            {
                return (int)_parent[AppSettingsKeys.schedUploadRate];
            }
            set
            {
                _parent[AppSettingsKeys.schedUploadRate] = value;
            }
        }

        public bool Interaction
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.schedInteraction];
            }
            set
            {
                _parent[AppSettingsKeys.schedInteraction] = value;
            }
        }

        public bool DistributeDht
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.schedDisDht];
            }
            set
            {
                _parent[AppSettingsKeys.schedDisDht] = value;
            }
        }

        public int DownloadRate
        {
            get
            {
                return (int)_parent[AppSettingsKeys.schedDownloadRate];
            }
            set
            {
                _parent[AppSettingsKeys.schedDownloadRate] = value;
            }
        }

        public string Table
        {
            get
            {
                return _parent[AppSettingsKeys.schedTable].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.schedTable] = value;
            }
        }

        protected internal SchedulingSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
