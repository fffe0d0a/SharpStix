using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class StixBinaryConverter : JsonConverter<StixBinary>
{
    public override StixBinary Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new StixBinary(reader.GetBytesFromBase64());

    public override void Write(Utf8JsonWriter writer, StixBinary value, JsonSerializerOptions options)
    {
        writer.WriteBase64StringValue(value.Value);
    }
}