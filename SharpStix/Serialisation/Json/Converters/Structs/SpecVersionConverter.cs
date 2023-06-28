using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class SpecVersionConverter : JsonConverter<SpecVersion>
{
    public override SpecVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        SpecVersion.GetVersion(reader.GetString() ?? throw new InvalidOperationException());

    public override void Write(Utf8JsonWriter writer, SpecVersion value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}