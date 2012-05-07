namespace UTorri
{
    /// <summary>
    /// Base class used by all http response object presentations.
    /// </summary>
    public abstract class RequestResult: IJsonFillable
    {
        /// <summary>
        /// Build version of current uTorrent application.
        /// </summary>
        public int Build { get; set; }

        public abstract void FromJson(string json);
    }
}
