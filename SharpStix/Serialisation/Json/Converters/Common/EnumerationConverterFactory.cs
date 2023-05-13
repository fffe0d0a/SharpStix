using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common;

namespace SharpStix.Serialisation.Json.Converters;

public class EnumerationConverterFactory : JsonConverterFactory
{
    public override bool CanConvert(Type typeToConvert)
    {
        return typeToConvert.BaseType?.GetGenericTypeDefinition() == typeof(Enumeration<>); //is type of Enumeration<>
    }

    public override JsonConverter? CreateConverter(Type typeToConvert, JsonSerializerOptions options)
    {
        Type converterType = typeof(EnumerationConverter<>).MakeGenericType(typeToConvert);
        JsonConverter? converter = (JsonConverter?)Activator.CreateInstance(converterType);
        return converter;
    }

    private class EnumerationConverter<T> : JsonConverter<T> where T : Enumeration<T>
    {
        public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string? value = reader.GetString();
            return value == null
                ? null :
                Enumeration<T>.FromDisplayName(value);
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}