using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ReportType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ReportType : StixOpenVocab, IFromString<ReportType>
{
    private const string TYPE = "report-type-ov";
    public static readonly ReportType AttackPattern = FromString("attack-pattern");

    public static readonly ReportType Campaign = FromString("campaign");

    public static readonly ReportType Identity = FromString("identity");

    public static readonly ReportType Indicator = FromString("indicator");

    public static readonly ReportType IntrusionSet = FromString("intrusion-set");

    public static readonly ReportType Malware = FromString("malware");

    public static readonly ReportType ObservedData = FromString("observed-data");

    public static readonly ReportType ThreatActor = FromString("threat-actor");

    public static readonly ReportType ThreatReport = FromString("threat-report");

    public static readonly ReportType Tool = FromString("tool");

    public static readonly ReportType Vulnerability = FromString("vulnerability");

    private ReportType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ReportType FromString(string value)
    {
        if (OpenVocabManager<ReportType>.TryGetValue(value, out ReportType? vocab))
            return vocab!;

        vocab = new ReportType(value);
        OpenVocabManager<ReportType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}