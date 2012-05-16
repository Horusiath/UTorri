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
    /// Multiday-oriented settings container
    /// </summary>
    public class MultidayTransferSettings : SettingsBase
    {

        public bool Limit
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.multiDayTransferLimitEn];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferLimitEn] = value;
            }
        }

        public bool ModeUpload
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.multiDayTransferModeUpload];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferModeUpload] = value;
            }
        }

        public bool ModeDownload
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.multiDayTransferModeDownload];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferModeDownload] = value;
            }
        }

        public bool ModeUploadDownload
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.multiDayTransferModeUploadDownload];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferModeUploadDownload] = value;
            }
        }

        public int LimitUnit
        {
            get
            {
                return (int)_parent[AppSettingsKeys.multiDayTransferLimitUnit];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferLimitUnit] = value;
            }
        }

        public int LimitValue
        {
            get
            {
                return (int)_parent[AppSettingsKeys.multiDayTransferLimitValue];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferLimitValue] = value;
            }
        }

        public int LimitSpan
        {
            get
            {
                return (int)_parent[AppSettingsKeys.multiDayTransferLimitSpan];
            }
            set
            {
                _parent[AppSettingsKeys.multiDayTransferLimitSpan] = value;
            }
        }

        protected MultidayTransferSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
