using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class ConfidenceConverter : JsonConverter<Confidence>
{
    public override Confidence Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new Confidence(reader.GetInt32());

    public override void Write(Utf8JsonWriter writer, Confidence value, JsonSerializerOptions options) =>
        writer.WriteNumberValue((int)value);
}