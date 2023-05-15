using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<HashingAlgorithm>))]
[StixTypeDiscriminator(TYPE)]
public sealed record HashingAlgorithm : StixOpenVocab, IFromString<HashingAlgorithm>
{
    private const string TYPE = "hashing-algorithm-ov";
    public static readonly HashingAlgorithm MD5 = FromString("MD5");
    public static readonly HashingAlgorithm SHA_1 = FromString("SHA-1");
    public static readonly HashingAlgorithm SHA_256 = FromString("SHA-256");
    public static readonly HashingAlgorithm SHA_512 = FromString("SHA-512");
    public static readonly HashingAlgorithm SHA3_256 = FromString("SHA3-256");
    public static readonly HashingAlgorithm SHA3_512 = FromString("SHA3-512");
    public static readonly HashingAlgorithm SSDeep = FromString("SSDEEP");
    public static readonly HashingAlgorithm TLSH = FromString("TLSH");

    private HashingAlgorithm(string Value) : base(Value)
    {
    }


    public override string Type => TYPE;

    public static HashingAlgorithm FromString(string value)
    {
        if (OpenVocabManager<HashingAlgorithm>.TryGetValue(value, out HashingAlgorithm? vocab))
            return vocab!;

        vocab = new HashingAlgorithm(value);
        OpenVocabManager<HashingAlgorithm>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}