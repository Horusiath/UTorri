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
    /// Net-oriented settings container.
    /// </summary>
    public class NetSettings:SettingsBase
    {
        public string BindIp
        {
            get
            {
                return _parent[AppSettingsKeys.netBindIp].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.netBindIp] = value;
            }
        }

        public string FriendlyName
        {
            get
            {
                return _parent[AppSettingsKeys.netFriendlyName].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.netFriendlyName] = value;
            }
        }

        public string OutgoingIp
        {
            get
            {
                return _parent[AppSettingsKeys.netOutgoingIp].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.netOutgoingIp] = value;
            }
        }

        public int OutgoingPort
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netOutgoingPort];
            }
            set
            {
                _parent[AppSettingsKeys.netOutgoingPort] = value;
            }
        }

        public int OutgoingMaxPort
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netOutgoingMaxPort];
            }
            set
            {
                _parent[AppSettingsKeys.netOutgoingMaxPort] = value;
            }
        }

        public int UtpTargetDelay
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netUtpTargetDelay];
            }
            set
            {
                _parent[AppSettingsKeys.netUtpTargetDelay] = value;
            }
        }

        public int UtpPacketSizeInterval
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netUtpPacketSizeInterval];
            }
            set
            {
                _parent[AppSettingsKeys.netUtpPacketSizeInterval] = value;
            }
        }

        public int UtpReceiveTargetDelay
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netUtpReceiveTargetDelay];
            }
            set
            {
                _parent[AppSettingsKeys.netUtpReceiveTargetDelay] = value;
            }
        }

        public int UtpInitialPacketSize
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netUtpInitialPackSize];
            }
            set
            {
                _parent[AppSettingsKeys.netUtpInitialPackSize] = value;
            }
        }

        public int MaxHalOpen
        {
            get
            {
                return (int)_parent[AppSettingsKeys.netMaxHalfopen];
            }
            set
            {
                _parent[AppSettingsKeys.netMaxHalfopen] = value;
            }
        }

        public bool LowCpu
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netLowCpu];
            }
            set
            {
                _parent[AppSettingsKeys.netLowCpu] = value;
            }
        }

        public bool UtpDynamicPacketSize
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netUtpDynamicPacketSize];
            }
            set
            {
                _parent[AppSettingsKeys.netUtpDynamicPacketSize] = value;
            }
        }

        public bool Discoverable
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netDicoverable];
            }
            set
            {
                _parent[AppSettingsKeys.netDicoverable] = value;
            }
        }

        public bool CalculateOverhead
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netCalcOverhead];
            }
            set
            {
                _parent[AppSettingsKeys.netCalcOverhead] = value;
            }
        }

        public bool CalculateRssOverhead
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netCalcRssOverhead];
            }
            set
            {
                _parent[AppSettingsKeys.netCalcRssOverhead] = value;
            }
        }

        public bool CalculateTrackerOverhead
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netCalcTrackerOverhead];
            }
            set
            {
                _parent[AppSettingsKeys.netCalcTrackerOverhead] = value;
            }
        }

        public bool LimitExcludesLocal
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netExcludesLocal];
            }
            set
            {
                _parent[AppSettingsKeys.netExcludesLocal] = value;
            }
        }

        public bool UpnpTcpOnly
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netUpnpTcpOnly];
            }
            set
            {
                _parent[AppSettingsKeys.netUpnpTcpOnly] = value;
            }
        }

        public bool DisableIncomingIpv6
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netDisableIncomingIpv6];
            }
            set
            {
                _parent[AppSettingsKeys.netDisableIncomingIpv6] = value;
            }
        }

        public bool RateLimitUtp
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.netRateLimitUtp];
            }
            set
            {
                _parent[AppSettingsKeys.netRateLimitUtp] = value;
            }
        }

        protected NetSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
