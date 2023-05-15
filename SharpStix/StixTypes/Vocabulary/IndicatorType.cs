using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IndicatorType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IndicatorType : StixOpenVocab, IFromString<IndicatorType>
{
    private const string TYPE = "indicator-type-ov";
    public static readonly IndicatorType AnomalousActivity = FromString("anomalous-activity");

    public static readonly IndicatorType Anonymisation = FromString("anonymization");

    public static readonly IndicatorType Benign = FromString("benign");

    public static readonly IndicatorType Compromised = FromString("compromised");

    public static readonly IndicatorType MaliciousActivity = FromString("malicious-activity");

    public static readonly IndicatorType Attribution = FromString("attribution");

    public static readonly IndicatorType Unknown = FromString("unknown");

    private IndicatorType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static IndicatorType FromString(string value)
    {
        if (OpenVocabManager<IndicatorType>.TryGetValue(value, out IndicatorType? vocab))
            return vocab!;

        vocab = new IndicatorType(value);
        OpenVocabManager<IndicatorType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}