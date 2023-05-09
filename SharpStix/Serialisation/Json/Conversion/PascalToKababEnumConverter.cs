using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Extensions;

namespace SharpStix.Serialisation.Json.Conversion;

public class PascalToKababEnumConverter<T> : JsonConverter<T> where T : struct, Enum
{
    public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) =>
        Enum.Parse<T>(reader.GetString()!.KebabToPascalCase(), true);

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString().PascalToKebabCase());
    }
}