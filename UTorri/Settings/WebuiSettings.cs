using System;

namespace UTorri.Settings
{
    /// <summary>
    /// Webui settings.
    /// </summary>
    public class WebuiSettings : SettingsBase
    {

        public int Enable
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiEnable];
            }
            set
            {
                _parent[AppSettingsKeys.webuiEnable] = value;
            }
        }

        public int Port
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiPort];
            }
            set
            {
                _parent[AppSettingsKeys.webuiPort] = value;
            }
        }

        public int EnableGuest
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiEnableGuest];
            }
            set
            {
                _parent[AppSettingsKeys.webuiEnableGuest] = value;
            }
        }

        public int EnableListen
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiEnableListen];
            }
            set
            {
                _parent[AppSettingsKeys.webuiEnableListen] = value;
            }
        }

        public bool TokenAuthorization
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiTokenAuth];
            }
            set
            {
                _parent[AppSettingsKeys.webuiTokenAuth] = value;
            }
        }

        public bool UConnectToolbarEver
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiUconnectToolbarEver];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectToolbarEver] = value;
            }
        }

        public bool UConnectEnableEver
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiUconnectEnableEver];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectEnableEver] = value;
            }
        }

        public bool UConnectConnectedEver
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiUconnectConnectedEver];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectConnectedEver] = value;
            }
        }

        public int UConnectActionsCount
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiUconnectActionsCount];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectActionsCount] = value;
            }
        }

        public int UConnectActionsListCount
        {
            get
            {
                return (int)_parent[AppSettingsKeys.webuiUconnectActionsListCount];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectActionsListCount] = value;
            }
        }

        public bool UConnectEnable
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiUconnectEnable];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectEnable] = value;
            }
        }

        public bool UConnectQuestionOptedOut
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiUconnectQuestionOptedOut];
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectQuestionOptedOut] = value;
            }
        }

        public bool AllowPairing
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.webuiAllowPairing];
            }
            set
            {
                _parent[AppSettingsKeys.webuiAllowPairing] = value;
            }
        }

        public string UConnectUsername
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUconnectUsername].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectUsername] = value;
            }
        }

        public string Cookie
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUconnectUsername].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectUsername] = value;
            }
        }

        public string UpdateMessage
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUpdateMessage].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUpdateMessage] = value;
            }
        }

        public Guid? SsdpUuid
        {
            get
            {
                var s = (_parent[AppSettingsKeys.webuiSsdpUuid] ?? string.Empty).ToString();
                if (string.IsNullOrEmpty(s)) return null;
                return new Guid(s);
            }
            set
            {
                if (value != null)
                    _parent[AppSettingsKeys.webuiSsdpUuid] = value.ToString();
                else _parent[AppSettingsKeys.webuiSsdpUuid] = null;
            }
        }

        public string UConnectComputerName
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUconnectComputername].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectComputername] = value;
            }
        }

        public string Guest
        {
            get
            {
                return _parent[AppSettingsKeys.webuiGuest].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiGuest] = value;
            }
        }

        public string UConnectPassword
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUconnectPassword].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectPassword] = value;
            }
        }

        public string UConnectAnonymousUsername
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUconnectUsernameAnonymous].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUconnectUsernameAnonymous] = value;
            }
        }

        public string Username
        {
            get
            {
                return _parent[AppSettingsKeys.webuiUsername].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiUsername] = value;
            }
        }

        public string Password
        {
            get
            {
                return _parent[AppSettingsKeys.webuiPassword].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.webuiPassword] = value;
            }
        }

        protected internal WebuiSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
