namespace UTorri
{
    public static class StandardExtensions
    {
        /// <summary>
        /// Encodes string into ASCIII encoded bytes.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static byte[] ToASCII(this string s)
        {
            var retval = new byte[s.Length];
            for (int ix = 0; ix < s.Length; ++ix)
            {
                var ch = s[ix];
                if (ch <= 0x7f) retval[ix] = (byte)ch;
                else retval[ix] = (byte)'?';
            }
            return retval;
        }
    }
}
