using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace UTorri.Settings
{
    /// <summary>
    /// Common interface for settings classes.
    /// </summary>
    public interface ISettings
    {
        /// <summary>
        /// Returns target setting.
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        object this[string index] { get; }
    }
}
