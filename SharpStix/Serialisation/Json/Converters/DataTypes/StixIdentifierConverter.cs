using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters.DataTypes;

public class StixIdentifierConverter : JsonConverter<StixIdentifier>
{
    public override StixIdentifier? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? s = reader.GetString();
        return s == null
            ? null :
            new StixIdentifier(s);
    }

    public override void Write(Utf8JsonWriter writer, StixIdentifier value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}