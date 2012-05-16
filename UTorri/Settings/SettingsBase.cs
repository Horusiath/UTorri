namespace UTorri.Settings
{
    /// <summary>
    /// Base class for other settings classes.
    /// </summary>
    public class SettingsBase :ISettings
    {
        protected ApplicationSettings _parent;

        protected internal SettingsBase(ApplicationSettings parent)
        {
            _parent = parent;
        }

        public object this[string index]
        {
            get { return _parent != null ? _parent[index] : null; }
        }
    }
}
