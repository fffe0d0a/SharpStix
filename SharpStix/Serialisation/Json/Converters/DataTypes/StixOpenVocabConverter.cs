using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.Serialisation.Json.Converters;

internal class StixOpenVocabConverter<T> : JsonConverter<T> where T : StixOpenVocab
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        return value == null 
            ? null : 
            StixOpenVocab.FromString<T>(value);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}