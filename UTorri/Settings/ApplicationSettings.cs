using System.Collections.Generic;
using Newtonsoft.Json;

namespace UTorri.Settings
{
    /// <summary>
    /// Application settings collection.
    /// </summary>
    public class ApplicationSettings: RequestResult, ISettings
    {
        private IDictionary<string,object> _dictionary = new Dictionary<string, object>();

        /// <summary>
        /// Gets build version.
        /// </summary>
        public int Build { get; protected set; }




        public override void FromJson(string json)
        {
            var parsed = JsonConvert.DeserializeObject(json, typeof (AppSettingsJson));

        }

        public object this[string index]
        {
            get
            {
                return _dictionary.ContainsKey(index) ? _dictionary[index] : null;
            }
            set
            {
                if (_dictionary.ContainsKey(index))
                    _dictionary[index] = value;
                _dictionary.Add(index,value);
            }
        }

        /// <summary>
        /// Class used for application settings json parsing.
        /// </summary>
        public class AppSettingsJson
        {
            public int build;
            public ICollection<object[]> settings;
        }

    }
}
