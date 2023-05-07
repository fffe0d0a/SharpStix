using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixBinaryConverter))]
public readonly record struct StixBinary(byte[] Value) : IStixDataType
{
    public static string TypeName => "binary";

    public override string ToString() => Convert.ToBase64String(Value);
}