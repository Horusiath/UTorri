using System;

namespace UTorri.Connection
{
    /// <summary>
    /// Exception type thrown on token parsing or token access failure.
    /// </summary>
    public class TokenException : Exception
    {
        public TokenException(string msg):base(msg){}
    }
}
