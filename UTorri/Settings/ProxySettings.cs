using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace UTorri.Settings
{
    /// <summary>
    /// Proxy settings.
    /// </summary>
    public class ProxySettings : SettingsBase
    {
        public string Proxy
        {
            get
            {
                return _parent[AppSettingsKeys.proxyProxy].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.proxyProxy] = value;
            }
        }
        public int Type
        {
            get
            {
                return (int)_parent[AppSettingsKeys.proxyType];
            }
            set
            {
                _parent[AppSettingsKeys.proxyType] = value;
            }
        }
        public int Port
        {
            get
            {
                return (int)_parent[AppSettingsKeys.proxyPort];
            }
            set
            {
                _parent[AppSettingsKeys.proxyPort] = value;
            }
        }
        public bool Authorization
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.proxyAuth];
            }
            set
            {
                _parent[AppSettingsKeys.proxyAuth] = value;
            }
        }
        public bool P2P
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.proxyP2p];
            }
            set
            {
                _parent[AppSettingsKeys.proxyP2p] = value;
            }
        }
        public bool Resolve
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.proxyResolve];
            }
            set
            {
                _parent[AppSettingsKeys.proxyResolve] = value;
            }
        }
        public string Username
        {
            get
            {
                return _parent[AppSettingsKeys.proxyUsername].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.proxyUsername] = value;
            }
        }
        public string Password
        {
            get
            {
                return _parent[AppSettingsKeys.proxyPassword].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.proxyPassword] = value;
            }
        }
        protected internal ProxySettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
