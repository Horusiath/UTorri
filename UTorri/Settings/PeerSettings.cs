namespace UTorri.Settings
{
    /// <summary>
    /// Peer-oriented settings class.
    /// </summary>
    public class PeerSettings : SettingsBase
    {
        public bool LazyBitfield
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.peerLazyBitfield];
            }
            set
            {
                _parent[AppSettingsKeys.peerLazyBitfield] = value;
            }
        }

        public bool ResolveCountry
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.peerResolveCountry];
            }
            set
            {
                _parent[AppSettingsKeys.peerResolveCountry] = value;
            }
        }
        
        public bool DisconnectInactive
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.peerDisconnectInactive];
            }
            set
            {
                _parent[AppSettingsKeys.peerDisconnectInactive] = value;
            }
        }

        public int DisconnectInactiveInterval
        {
            get
            {
                return (int)_parent[AppSettingsKeys.peerDisconnectInactiveInterval];
            }
            set
            {
                _parent[AppSettingsKeys.peerDisconnectInactiveInterval] = value;
            }
        }

        protected internal PeerSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
