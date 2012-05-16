namespace UTorri.Settings
{
    /// <summary>
    /// Disk input-output settings container.
    /// </summary>
    public class DiskIOSettings : SettingsBase
    {
        public bool FlushFiles
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioFlushFiles];
            }
            set
            {
                _parent[AppSettingsKeys.diskioFlushFiles] = value;
            }
        }

        public bool SparseFiles
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioSparseFiles];
            }
            set
            {
                _parent[AppSettingsKeys.diskioSparseFiles] = value;
            }
        }

        public bool NoZero
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioNoZero];
            }
            set
            {
                _parent[AppSettingsKeys.diskioNoZero] = value;
            }
        }

        public bool UserPartFile
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioUserPartfile];
            }
            set
            {
                _parent[AppSettingsKeys.diskioUserPartfile] = value;
            }
        }

        public bool SmartHash
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioSmartHash];
            }
            set
            {
                _parent[AppSettingsKeys.diskioSmartHash] = value;
            }
        }

        public bool SmartSparseHash
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioSmartSparseHash];
            }
            set
            {
                _parent[AppSettingsKeys.diskioSmartSparseHash] = value;
            }
        }

        public bool CoalesceWrites
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.diskioCoalesceWrtes];
            }
            set
            {
                _parent[AppSettingsKeys.diskioCoalesceWrtes] = value;
            }
        }

        public int CoalesceWriteSize
        {
            get
            {
                return (int)_parent[AppSettingsKeys.diskioCoalesceWriteSize];
            }
            set
            {
                _parent[AppSettingsKeys.diskioCoalesceWriteSize] = value;
            }
        }

        public int ResumeMin
        {
            get
            {
                return (int)_parent[AppSettingsKeys.diskioResumeMin];
            }
            set
            {
                _parent[AppSettingsKeys.diskioResumeMin] = value;
            }
        }

        public int MaxWriteQueue
        {
            get
            {
                return (int)_parent[AppSettingsKeys.diskioMaxWriteQueue];
            }
            set
            {
                _parent[AppSettingsKeys.diskioMaxWriteQueue] = value;
            }
        }

        public int CacheReduceMinutes
        {
            get
            {
                return (int)_parent[AppSettingsKeys.diskioCacheReduceMinutes];
            }
            set
            {
                _parent[AppSettingsKeys.diskioCacheReduceMinutes] = value;
            }
        }

        public int CacheStripe
        {
            get
            {
                return (int)_parent[AppSettingsKeys.diskioCacheStripe];
            }
            set
            {
                _parent[AppSettingsKeys.diskioCacheStripe] = value;
            }
        }

        protected internal DiskIOSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
