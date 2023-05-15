using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<PatternType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record PatternType : StixOpenVocab, IFromString<PatternType>
{
    private const string TYPE = "pattern-type-ov";
    public static readonly PatternType Stix = FromString("stix");

    public static readonly PatternType Pcre = FromString("pcre");

    public static readonly PatternType Sigma = FromString("sigma");

    public static readonly PatternType Snort = FromString("snort");

    public static readonly PatternType Suricata = FromString("suricata");

    public static readonly PatternType Yara = FromString("yara");

    private PatternType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static PatternType FromString(string value)
    {
        if (OpenVocabManager<PatternType>.TryGetValue(value, out PatternType? vocab))
            return vocab!;

        vocab = new PatternType(value);
        OpenVocabManager<PatternType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}