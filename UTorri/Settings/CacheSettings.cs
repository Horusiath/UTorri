namespace UTorri.Settings
{
    /// <summary>
    /// Cache settings.
    /// </summary>
    public class CacheSettings : SettingsBase
    {
        public bool Override
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheOverride];
            }
            set
            {
                _parent[AppSettingsKeys.cacheOverride] = value;
            }
        }
        public int OverrideSize
        {
            get
            {
                return (int)_parent[AppSettingsKeys.cacheOverrideSize];
            }
            set
            {
                _parent[AppSettingsKeys.cacheOverrideSize] = value;
            }
        }
        public bool Reduce
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheReduce];
            }
            set
            {
                _parent[AppSettingsKeys.cacheReduce] = value;
            }
        }
        public bool Write
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheWrite];
            }
            set
            {
                _parent[AppSettingsKeys.cacheWrite] = value;
            }
        }
        public bool WriteImm
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheWriteimm];
            }
            set
            {
                _parent[AppSettingsKeys.cacheWriteimm] = value;
            }
        }
        public bool Writeout
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheWriteout];
            }
            set
            {
                _parent[AppSettingsKeys.cacheWriteout] = value;
            }
        }
        public bool Read
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheRead];
            }
            set
            {
                _parent[AppSettingsKeys.cacheRead] = value;
            }
        }
        public bool ReadTurnoff
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheReadTurnoff];
            }
            set
            {
                _parent[AppSettingsKeys.cacheReadTurnoff] = value;
            }
        }
        public bool ReadPrune
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheReadPrune];
            }
            set
            {
                _parent[AppSettingsKeys.cacheReadPrune] = value;
            }
        }
        public bool ReadThrash
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheReadThrash];
            }
            set
            {
                _parent[AppSettingsKeys.cacheReadThrash] = value;
            }
        }
        public bool DisableWinRead
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheDisableWinRead];
            }
            set
            {
                _parent[AppSettingsKeys.cacheDisableWinRead] = value;
            }
        }
        public bool DisableWinWrite
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.cacheDisableWinWrite];
            }
            set
            {
                _parent[AppSettingsKeys.cacheDisableWinWrite] = value;
            }
        }
        protected internal CacheSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
