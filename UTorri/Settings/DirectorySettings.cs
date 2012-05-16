namespace UTorri.Settings
{
    /// <summary>
    /// Directory-oriented settings container.
    /// </summary>
    public class DirectorySettings : SettingsBase
    {
        public bool ActiveDownloadFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirActiveDownloadFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirActiveDownloadFlag] = value;
            }
        }

        public bool TorrentFilesFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirTorrentFilesFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirTorrentFilesFlag] = value;
            }
        }

        public bool NotifyComplete
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirNotifyComplete];
            }
            set
            {
                _parent[AppSettingsKeys.dirNotifyComplete] = value;
            }
        }

        public bool CompletedDownloadFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirCompletedDownloadFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirCompletedDownloadFlag] = value;
            }
        }

        public bool CompletedTorrentsFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirCompletedTorrentsFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirCompletedTorrentsFlag] = value;
            }
        }

        public string ActiveDownload
        {
            get
            {
                return _parent[AppSettingsKeys.dirActiveDownload].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.dirActiveDownload] = value;
            }
        }

        public string TorrentFiles
        {
            get
            {
                return _parent[AppSettingsKeys.dirTorrentFiles].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.dirTorrentFiles] = value;
            }
        }

        public string CompletedDownloads
        {
            get
            {
                return _parent[AppSettingsKeys.dirCompletedDownload].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.dirCompletedDownload] = value;
            }
        }

        public string AutoLoad
        {
            get
            {
                return _parent[AppSettingsKeys.dirAutoload].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.dirAutoload] = value;
            }
        }

        public bool CompletedDownloadsFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirCompletedDownloadFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirCompletedDownloadFlag] = value;
            }
        }

        public bool DirAddLabel
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirAddLabel];
            }
            set
            {
                _parent[AppSettingsKeys.dirAddLabel] = value;
            }
        }

        public bool AutoloadFlag
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirAutoloadFlag];
            }
            set
            {
                _parent[AppSettingsKeys.dirAutoloadFlag] = value;
            }
        }

        public bool AutoloadDelete
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.dirAutoloadDelete];
            }
            set
            {
                _parent[AppSettingsKeys.dirAutoloadDelete] = value;
            }
        }


        protected internal DirectorySettings(ApplicationSettings parent)
            : base(parent)
        {
        }
    }
}
