using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IndicatorType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IndicatorType(string Value) : StixOpenVocab(Value)
{
    public static readonly IndicatorType AnomalousActivity = new IndicatorType("anomalous-activity");

    public static readonly IndicatorType Anonymisation = new IndicatorType("anonymization");

    public static readonly IndicatorType Benign = new IndicatorType("benign");

    public static readonly IndicatorType Compromised = new IndicatorType("compromised");

    public static readonly IndicatorType MaliciousActivity = new IndicatorType("malicious-activity");

    public static readonly IndicatorType Attribution = new IndicatorType("attribution");

    public static readonly IndicatorType Unknown = new IndicatorType("unknown");

    private const string TYPE = "indicator-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}