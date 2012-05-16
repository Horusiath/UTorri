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
    /// Base class for other settings classes.
    /// </summary>
    public class SettingsBase :ISettings
    {
        protected ApplicationSettings _parent;

        protected SettingsBase(ApplicationSettings parent)
        {
            _parent = parent;
        }

        public object this[string index]
        {
            get { return _parent != null ? _parent[index] : null; }
        }
    }
}
