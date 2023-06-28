using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixObjects;

namespace SharpStix.Serialisation.Json.Converters;

public class SelectorConverter : JsonConverter<Selector>
{
    public override Selector? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        return value == null
            ? null
            : new Selector(value);
    }

    public override void Write(Utf8JsonWriter writer, Selector value, JsonSerializerOptions options) =>
        writer.WriteStringValue(value.ToString());
}