using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using UTorri.Settings;

namespace UTorri.Commands
{
    /// <summary>
    /// Query command associated with application settings request.
    /// </summary>
    public class AppSettingsQueryCommand : QueryCommand
    {
        private const string GetActionName = "?action=getsettings";
        private const string SetActionName = "?action=setsetting";

        /// <summary>
        /// Creates new instance of application settings query command for get application
        /// settings request.
        /// </summary>
        public AppSettingsQueryCommand():base(GetActionName, CommandType.Action)
        {
        }

        /// <summary>
        /// Creates new instance of application settings query command for set application
        /// settings request. 
        /// </summary>
        /// <param name="settings"></param>
        /// <remarks>This method takes snapshot of current application settings state. Any further changes on settings will not be noticed.</remarks>
        public AppSettingsQueryCommand(ApplicationSettings settings):base(SetActionName, CommandType.Action)
        {
            var list = new List<KeyValuePair<string, string>>();
            foreach (var o in settings.Changeset)
            {
                list.Add(new KeyValuePair<string, string>("s", o.Key));
                list.Add(new KeyValuePair<string, string>("v", GetValue(o.Value)));
            }
            Parameters = list;
        }

        private static string GetValue(object obj)
        {
            var type = obj.GetType();
            if (type == typeof(bool))
                return ((bool) obj) ? "1" : "0";

            return obj.ToString();
        }

    }
}
