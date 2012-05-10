using System;

namespace UTorri.Client
{
    /// <summary>
    /// EventArgs class used by RemoteClient event handlers.
    /// </summary>
    public class RemoteClientResponseEventArgs : EventArgs
    {
        /// <summary>
        /// Result brought by http response.
        /// </summary>
        public object Result { get; private set; }

        /// <summary>
        /// Raw responses data as json string.
        /// </summary>
        public string RawData { get; set; }

        public RemoteClientResponseEventArgs(object result, string raw)
        {
            Result = result;
            RawData = raw;
        }
    }
}
