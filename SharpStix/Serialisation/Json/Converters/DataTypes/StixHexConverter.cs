using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class StixHexConverter : JsonConverter<StixHex>
{
    public override StixHex Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => new StixHex(reader.GetString() ?? throw new InvalidOperationException());

    public override void Write(Utf8JsonWriter writer, StixHex value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}