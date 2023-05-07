using System.Text.Json;
using System.Text.Json.Serialization;

namespace SharpStix.Serialisation.Json.Converters;

public class BinaryConverter : JsonConverter<byte[]>
{
    public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.GetBytesFromBase64();
    }

    public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
    {
        writer.WriteBase64StringValue(new ReadOnlySpan<byte>(value));
    }
}