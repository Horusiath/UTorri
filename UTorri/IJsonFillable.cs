namespace UTorri
{
    /// <summary>
    /// Interface used by all JSON self parsing-available classes.
    /// </summary>
    public interface IJsonFillable
    {
        void FromJson(string json);
    }
}
