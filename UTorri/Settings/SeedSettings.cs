namespace UTorri.Settings
{
    /// <summary>
    /// Seed-oriented settings container.
    /// </summary>
    public class SeedSettings : SettingsBase
    {
        public int PriorityLimitUpload
        {
            get
            {
                return (int)_parent[AppSettingsKeys.seedPrioLimitUpload];
            }
            set
            {
                _parent[AppSettingsKeys.seedPrioLimitUpload] = value;
            }
        }

        public int Ratio
        {
            get
            {
                return (int)_parent[AppSettingsKeys.seedRatio];
            }
            set
            {
                _parent[AppSettingsKeys.seedRatio] = value;
            }
        }

        public int Time
        {
            get
            {
                return (int)_parent[AppSettingsKeys.seedTime];
            }
            set
            {
                _parent[AppSettingsKeys.seedTime] = value;
            }
        }

        public int Number
        {
            get
            {
                return (int)_parent[AppSettingsKeys.seedNumber];
            }
            set
            {
                _parent[AppSettingsKeys.seedNumber] = value;
            }
        }

        public bool PriorityLimitUploadFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.seedPrioLimitUploadFlag];
            }
            set
            {
                _parent[AppSettingsKeys.seedPrioLimitUploadFlag] = value;
            }
        }

        public bool Prioritized
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.seedsPrioritized];
            }
            set
            {
                _parent[AppSettingsKeys.seedsPrioritized] = value;
            }
        }

        protected internal SeedSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
