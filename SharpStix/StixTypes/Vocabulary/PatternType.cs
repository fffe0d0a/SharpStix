using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<PatternType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record PatternType(string Value) : StixOpenVocab(Value)
{
    public static readonly PatternType Stix = new PatternType("stix");

    public static readonly PatternType Pcre = new PatternType("pcre");

    public static readonly PatternType Sigma = new PatternType("sigma");

    public static readonly PatternType Snort = new PatternType("snort");

    public static readonly PatternType Suricata = new PatternType("suricata");

    public static readonly PatternType Yara = new PatternType("yara");

    private const string TYPE = "pattern-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}