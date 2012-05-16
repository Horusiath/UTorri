using System.Collections.Generic;

namespace UTorri.Settings
{

    /// <summary>
    /// Bit torrent protocol oriented settings container.
    /// </summary>
    public class BitTorrentSettings : SettingsBase
    {
        public int SaveResumeRate
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btSaveResumeRate];
            }
            set
            {
                _parent[AppSettingsKeys.btSaveResumeRate] = value;
            }
        }

        public int AutoDownloadInterval
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btAutoDownloadInterval];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadInterval] = value;
            }
        }

        public int AutoDownloadQosMin
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btAutoDownloadQosMin];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadQosMin] = value;
            }
        }

        public int AutoDownloadSampleWindow
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btAutoDownloadSampleWindow];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadSampleWindow] = value;
            }
        }

        public int AutoDownloadSampleAverage
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btAutoDownloadSampleAverage];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadSampleAverage] = value;
            }
        }

        public int AutoDownloadFactor
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btAutoDownloadFactor];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadFactor] = value;
            }
        }

        public int PulseInterval
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btPulseInterval];
            }
            set
            {
                _parent[AppSettingsKeys.btPulseInterval] = value;
            }
        }

        public int PulseWeight
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btPulseWeight];
            }
            set
            {
                _parent[AppSettingsKeys.btPulseWeight] = value;
            }
        }

        public int ConnectionSpeed
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btConnectSpeed];
            }
            set
            {
                _parent[AppSettingsKeys.btConnectSpeed] = value;
            }
        }

        public int TransparentDisposition
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btTranspDisposition];
            }
            set
            {
                _parent[AppSettingsKeys.btTranspDisposition] = value;
            }
        }

        public int FailoverPeerSpeedThreshold
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btFailoverPeerSpeedThreshold];
            }
            set
            {
                _parent[AppSettingsKeys.btFailoverPeerSpeedThreshold] = value;
            }
        }

        public int ShutdownTrackerTimeout
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btShutdownTrackerTimeout];
            }
            set
            {
                _parent[AppSettingsKeys.btShutdownTrackerTimeout] = value;
            }
        }

        public int ShutdownUpnpTimeout
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btShutdownUpnpTimeout];
            }
            set
            {
                _parent[AppSettingsKeys.btShutdownUpnpTimeout] = value;
            }
        }

        public int BanThreshold
        {
            get
            {
                return (int)_parent[AppSettingsKeys.btBanThreshold];
            }
            set
            {
                _parent[AppSettingsKeys.btBanThreshold] = value;
            }
        }

        public bool DetermineEncodedRateForStreamables
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btDetermineEncodedRateForStreamables];
            }
            set
            {
                _parent[AppSettingsKeys.btDetermineEncodedRateForStreamables] = value;
            }
        }

        public bool BanRatio
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btBanRatio];
            }
            set
            {
                _parent[AppSettingsKeys.btBanRatio] = value;
            }
        }

        public bool UseRangeBlock
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btUseRangeBlock];
            }
            set
            {
                _parent[AppSettingsKeys.btUseRangeBlock] = value;
            }
        }

        public bool GracefulShutdown
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btGracefulShutdown];
            }
            set
            {
                _parent[AppSettingsKeys.btGracefulShutdown] = value;
            }
        }

        public bool AllowSameIp
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btAllowSameIp];
            }
            set
            {
                _parent[AppSettingsKeys.btAllowSameIp] = value;
            }
        }

        public bool NoConnectionToServices
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btNoConnectToServices];
            }
            set
            {
                _parent[AppSettingsKeys.btNoConnectToServices] = value;
            }
        }

        public IList<int> NoConnectionToServicesList
        {
            get
            {
                return (IList<int>)_parent[AppSettingsKeys.btNoConnectToServicesList];
            }
            set
            {
                _parent[AppSettingsKeys.btNoConnectToServicesList] = value;
            }
        }

        public bool AutoDownloadEnable
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btAutoDownloadEnable];
            }
            set
            {
                _parent[AppSettingsKeys.btAutoDownloadEnable] = value;
            }
        }

        public bool TcpRateControl
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btTcpRateControl];
            }
            set
            {
                _parent[AppSettingsKeys.btTcpRateControl] = value;
            }
        }

        public bool RateLimiTcpOnly
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btRateLimitTcpOnly];
            }
            set
            {
                _parent[AppSettingsKeys.btRateLimitTcpOnly] = value;
            }
        }

        public bool EnablePulse
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btEnablePuls];
            }
            set
            {
                _parent[AppSettingsKeys.btEnablePuls] = value;
            }
        }

        public bool PrioritizePartialPieces
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.btPrioritizePartialPieces];
            }
            set
            {
                _parent[AppSettingsKeys.btPrioritizePartialPieces] = value;
            }
        }

        protected internal BitTorrentSettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
