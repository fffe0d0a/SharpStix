using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixObjects.Meta;

namespace SharpStix.Serialisation.Json.Converters;

public class ObjectDefinitionConverter : JsonConverter<ObjectDefinition>
{
    public override ObjectDefinition?
        Read(ref Utf8JsonReader reader, Type typeToConvert,
            JsonSerializerOptions options) //warn hard-coded property names
    {
        using JsonDocument document = JsonDocument.ParseValue(ref reader);

        if (document.RootElement.TryGetProperty("tlp", out _))
            return document.Deserialize<TlpDefinition>(options);

        if (document.RootElement.TryGetProperty("statement", out _))
            return document.Deserialize<StatementDefinition>(options);

        throw new Exception("Unknown object definition type.");
    }

    public override void Write(Utf8JsonWriter writer, ObjectDefinition value, JsonSerializerOptions options)
    {
        switch (value)
        {
            case TlpDefinition tlp:
                writer.WriteRawValue(JsonSerializer.SerializeToUtf8Bytes(tlp, options));
                break;
            case StatementDefinition statement:
                writer.WriteRawValue(JsonSerializer.SerializeToUtf8Bytes(statement, options));
                break;
            default:
                throw new Exception("Unknown object definition type.");
        }
    }
}