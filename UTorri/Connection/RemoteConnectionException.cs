using System;

namespace UTorri.Connection
{
    /// <summary>
    /// Exception type thrown on remote connection failure.
    /// </summary>
    public class RemoteConnectionException : Exception
    {
        public RemoteConnectionException(string msg):base(msg){}
    }
}
