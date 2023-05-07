namespace SharpStix.StixTypes;

public readonly record struct StixHex(byte[] Value) : IStixDataType
{
    public StixHex(string value) : this(Convert.FromHexString(value))
    {
    }

    public static string TypeName => "hex";

    public override string ToString()
    {
        return Convert.ToHexString(Value).ToLowerInvariant();
    }
}