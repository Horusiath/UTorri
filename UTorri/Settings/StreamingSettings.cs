namespace UTorri.Settings
{
    /// <summary>
    /// Streaming-oriented settings container.
    /// </summary>
    public class StreamingSettings : SettingsBase
    {
        public int SafetyFactor
        {
            get
            {
                return (int)_parent[AppSettingsKeys.streamingSafetyFactor];
            }
            set
            {
                _parent[AppSettingsKeys.streamingSafetyFactor] = value;
            }
        }

        public int FailoverRateFactor
        {
            get
            {
                return (int)_parent[AppSettingsKeys.streamingFailoverRateFactor];
            }
            set
            {
                _parent[AppSettingsKeys.streamingFailoverRateFactor] = value;
            }
        }


        public int FailoverSetPercentage
        {
            get
            {
                return (int)_parent[AppSettingsKeys.streamingFailoverSetPercentage];
            }
            set
            {
                _parent[AppSettingsKeys.streamingFailoverSetPercentage] = value;
            }
        }

        public string PreviewPlayer
        {
            get
            {
                return _parent[AppSettingsKeys.streamingPreviewPlayer].ToString();
            }
            set
            {
                _parent[AppSettingsKeys.streamingPreviewPlayer] = value;
            }
        }

        protected StreamingSettings(ApplicationSettings parent) : base(parent)
        {
        }
    }
}
