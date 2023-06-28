using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.Serialisation.Json.Converters;

internal class StixOpenVocabConverter<T> : JsonConverter<T> where T : StixOpenVocab, IFromString<T>
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        return value == null
            ? null
            : T.FromString(value);
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}