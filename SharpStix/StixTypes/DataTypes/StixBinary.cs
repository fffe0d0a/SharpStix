using SharpStix.Common;

namespace SharpStix.StixTypes;

public readonly record struct StixBinary(byte[] Value) : IStixDataType
{
    public static string TypeName => "binary";

    public override string ToString() => Convert.ToBase64String(Value);
}