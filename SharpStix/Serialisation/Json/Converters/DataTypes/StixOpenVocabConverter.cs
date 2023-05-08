using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.Serialisation.Json.Converters;

internal class StixOpenVocabConverter<T> : JsonConverter<T> where T : StixOpenVocab
{
    public override T? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        string? value = reader.GetString();
        if (value == null)
            return null;

        return
            (T)Activator.CreateInstance(typeToConvert,
                value)!; //why don't 'you' write all of those separate converters?
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}