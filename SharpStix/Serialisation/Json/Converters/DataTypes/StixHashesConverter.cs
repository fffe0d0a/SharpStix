using System.Collections;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.Serialisation.Json.Converters;

public class StixHashesConverter : JsonConverter<StixHashes>
{
    public override StixHashes Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        StixHashes hashes = new StixHashes();

        JsonDocument document = JsonDocument.ParseValue(ref reader);
        foreach (JsonProperty jsonProperty in document.RootElement.EnumerateObject())
        {
            HashingAlgorithm algorithm = StixOpenVocab.FromString<HashingAlgorithm>(jsonProperty.Name);
            hashes.Add(algorithm, jsonProperty.Value.ToString());
        }

        return hashes;
    }

    public override void Write(Utf8JsonWriter writer, StixHashes value, JsonSerializerOptions options)
    {
        Dictionary<string, string> niceJsonDict = new Dictionary<string, string>();
        foreach (KeyValuePair<HashingAlgorithm, string> pair in value)
        {
            niceJsonDict.Add(pair.Key.ToString(), pair.Value);
        }

        using JsonDocument document = JsonSerializer.SerializeToDocument(niceJsonDict, options);
        document.WriteTo(writer);
    }
}