using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<HashingAlgorithm>))]
[StixTypeDiscriminator(TYPE)]
public sealed record HashingAlgorithm(string Value) : StixOpenVocab(Value)
{
    public static readonly HashingAlgorithm MD5 = new HashingAlgorithm("MD5");
    public static readonly HashingAlgorithm SHA_1 = new HashingAlgorithm("SHA-1");
    public static readonly HashingAlgorithm SHA_256 = new HashingAlgorithm("SHA-256");
    public static readonly HashingAlgorithm SHA_512 = new HashingAlgorithm("SHA-512");
    public static readonly HashingAlgorithm SHA3_256 = new HashingAlgorithm("SHA3-256");
    public static readonly HashingAlgorithm SHA3_512 = new HashingAlgorithm("SHA3-512");
    public static readonly HashingAlgorithm SSDeep = new HashingAlgorithm("SSDEEP");
    public static readonly HashingAlgorithm TLSH = new HashingAlgorithm("TLSH");


    private const string TYPE = "hashing-algorithm-ov";


    public override string Type => TYPE;
}