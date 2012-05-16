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
    /// Data visualisation oriented settings container.
    /// </summary>
    public class ShowSettings : SettingsBase
    {
        public bool Toolbar
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showToolbar];
            }
            set
            {
                _parent[AppSettingsKeys.showToolbar] = value;
            }
        }

        public bool Details
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showDetails];
            }
            set
            {
                _parent[AppSettingsKeys.showDetails] = value;
            }
        }

        public bool Status
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showStatus];
            }
            set
            {
                _parent[AppSettingsKeys.showStatus] = value;
            }
        }

        public bool Category
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showCategory];
            }
            set
            {
                _parent[AppSettingsKeys.showCategory] = value;
            }
        }

        public bool TabIcons
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showTabIcons];
            }
            set
            {
                _parent[AppSettingsKeys.showTabIcons] = value;
            }
        }

        public bool GeneralTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showGeneralTab];
            }
            set
            {
                _parent[AppSettingsKeys.showGeneralTab] = value;
            }
        }

        public bool PulseTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showPulseTab];
            }
            set
            {
                _parent[AppSettingsKeys.showPulseTab] = value;
            }
        }

        public bool TrackerTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showTrackerTab];
            }
            set
            {
                _parent[AppSettingsKeys.showTrackerTab] = value;
            }
        }

        public bool PeersTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showPeersTab];
            }
            set
            {
                _parent[AppSettingsKeys.showPeersTab] = value;
            }
        }

        public bool PiecesTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showPiecesTab];
            }
            set
            {
                _parent[AppSettingsKeys.showPiecesTab] = value;
            }
        }

        public bool FilesTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showFilesTab];
            }
            set
            {
                _parent[AppSettingsKeys.showFilesTab] = value;
            }
        }

        public bool SpeedTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showSpeedTab];
            }
            set
            {
                _parent[AppSettingsKeys.showSpeedTab] = value;
            }
        }

        public bool LoggerTab
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showLoggerTab];
            }
            set
            {
                _parent[AppSettingsKeys.showLoggerTab] = value;
            }
        }

        public bool AddDialog
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showAddDialog];
            }
            set
            {
                _parent[AppSettingsKeys.showAddDialog] = value;
            }
        }

        public bool AlwaysAddDialog
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.showAddDialogAlways];
            }
            set
            {
                _parent[AppSettingsKeys.showAddDialogAlways] = value;
            }
        }

        protected ShowSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
