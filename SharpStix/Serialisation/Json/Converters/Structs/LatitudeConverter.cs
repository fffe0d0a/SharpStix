using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class LatitudeConverter : JsonConverter<Latitude>
{
    public override Latitude Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new Latitude(reader.GetDouble());

    public override void Write(Utf8JsonWriter writer, Latitude value, JsonSerializerOptions options) =>
        writer.WriteNumberValue(value);
}