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

        public RemoteClientResponseEventArgs(object result)
        {
            Result = result;
        }
    }
}
