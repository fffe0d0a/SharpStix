using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class LongitudeConverter : JsonConverter<Longitude>
{
    public override Longitude Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => new Longitude(reader.GetDouble());

    public override void Write(Utf8JsonWriter writer, Longitude value, JsonSerializerOptions options) => writer.WriteNumberValue(value);
}