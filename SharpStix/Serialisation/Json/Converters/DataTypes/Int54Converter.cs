using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Serialisation.Json.Converters;

public class Int54Converter : JsonConverter<Int54>
{
    public override Int54 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        new Int54(reader.GetInt64());

    public override void Write(Utf8JsonWriter writer, Int54 value, JsonSerializerOptions options) =>
        writer.WriteNumberValue(value);
}