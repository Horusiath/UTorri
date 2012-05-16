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
    /// Statistics oriented settings container.
    /// </summary>
    public class StatsSettings : SettingsBase
    {
        public int WelcomePageUseful
        {
            get
            {
                return (int)_parent[AppSettingsKeys.statsWelcomePageUseful];
            }
            set
            {
                _parent[AppSettingsKeys.statsWelcomePageUseful] = value;
            }
        }

        public int Video1TimeWatched
        {
            get
            {
                return (int)_parent[AppSettingsKeys.statsVideo1TimeWatched];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo1TimeWatched] = value;
            }
        }

        public int Video2TimeWatched
        {
            get
            {
                return (int)_parent[AppSettingsKeys.statsVideo2TimeWatched];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo2TimeWatched] = value;
            }
        }

        public int Video3TimeWatched
        {
            get
            {
                return (int)_parent[AppSettingsKeys.statsVideo3TimeWatched];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo3TimeWatched] = value;
            }
        }

        public bool Video3Finished
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.statsVideo3Finished];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo3Finished] = value;
            }
        }

        public bool Video1Finished
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.statsVideo1Finished];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo1Finished] = value;
            }
        }

        public bool Video2Finished
        {
            get
            {
                return (bool)_parent[AppSettingsKeys.statsVideo2Finished];
            }
            set
            {
                _parent[AppSettingsKeys.statsVideo2Finished] = value;
            }
        }

        protected StatsSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
