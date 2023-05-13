using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ReportType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ReportType(string Value) : StixOpenVocab(Value)
{
    public static readonly ReportType AttackPattern = new ReportType("attack-pattern");

    public static readonly ReportType Campaign = new ReportType("campaign");

    public static readonly ReportType Identity = new ReportType("identity");

    public static readonly ReportType Indicator = new ReportType("indicator");

    public static readonly ReportType IntrusionSet = new ReportType("intrusion-set");

    public static readonly ReportType Malware = new ReportType("malware");

    public static readonly ReportType ObservedData = new ReportType("observed-data");

    public static readonly ReportType ThreatActor = new ReportType("threat-actor");

    public static readonly ReportType ThreatReport = new ReportType("threat-report");

    public static readonly ReportType Tool = new ReportType("tool");

    public static readonly ReportType Vulnerability = new ReportType("vulnerability");

    private const string TYPE = "report-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}