using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class StixTimestampConverter : JsonConverter<StixTimestamp>
{
    public override StixTimestamp Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new StixTimestamp(reader.GetDateTime());

    public override void Write(Utf8JsonWriter writer, StixTimestamp value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}