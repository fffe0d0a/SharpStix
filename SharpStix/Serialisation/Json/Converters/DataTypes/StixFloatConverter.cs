using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class StixFloatConverter : JsonConverter<StixFloat>
{
    public override StixFloat Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new StixFloat(reader.GetDouble());

    public override void Write(Utf8JsonWriter writer, StixFloat value, JsonSerializerOptions options) =>
        writer.WriteNumberValue(value.Value);
}