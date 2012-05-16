namespace UTorri.Settings
{
    /// <summary>
    /// Isp-oriented settings container.
    /// </summary>
    public class IspSettings : SettingsBase
    {
        public bool Bep22
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.ispBep22];
            }
            set
            {
                _parent[AppSettingsKeys.ispBep22] = value;
            }
        }

        public string PrimaryDns
        {
            get
            {
                return _parent[AppSettingsKeys.ispPrimaryDns].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.ispPrimaryDns] = value;
            }
        }

        public string SecondaryDns
        {
            get
            {
                return _parent[AppSettingsKeys.ispSecondaryDns].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.ispSecondaryDns] = value;
            }
        }

        public string Fqdn
        {
            get
            {
                return _parent[AppSettingsKeys.ispFqdn].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.ispFqdn] = value;
            }
        }

        public string PeerPolicyUrl
        {
            get
            {
                return _parent[AppSettingsKeys.ispPeerPolicyUrl].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.ispPeerPolicyUrl] = value;
            }
        }

        public bool PeerPolicyEnable
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.ispPeerPolicyEnable];
            }
            set
            {
                _parent[AppSettingsKeys.ispPeerPolicyEnable] = value;
            }
        }

        public bool PeerPolicyOverride
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.ispPeerPolicyOverride];
            }
            set
            {
                _parent[AppSettingsKeys.ispPeerPolicyOverride] = value;
            }
        }

        protected IspSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
