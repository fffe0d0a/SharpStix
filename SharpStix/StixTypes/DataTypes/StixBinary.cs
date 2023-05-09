using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixBinaryConverter))]
public readonly record struct StixBinary(byte[] Value) : IStixDataType
{
    private const string TYPE = "binary";

    public override string ToString()
    {
        return Convert.ToBase64String(Value);
    }
}