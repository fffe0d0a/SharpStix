using System.Text.Json.Serialization;
using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ReportType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ReportType(string Value) : StixOpenVocab(Value)
{
    public enum EReportType
    {
        /// <summary>
        ///     Report subject is a characterization of one or more attack patterns and related information.
        /// </summary>
        AttackPattern,

        /// <summary>
        ///     Report subject is a characterization of one or more campaigns and related information.
        /// </summary>
        Campaign,

        /// <summary>
        ///     Report subject is a characterization of one or more identities and related information.
        /// </summary>
        Identity,

        /// <summary>
        ///     Report subject is a characterization of one or more indicators and related information.
        /// </summary>
        Indicator,

        /// <summary>
        ///     Report subject is a characterization of one or more intrusion sets and related information.
        /// </summary>
        IntrusionSet,

        /// <summary>
        ///     Report subject is a characterization of one or more malware instances and related information.
        /// </summary>
        Malware,

        /// <summary>
        ///     Report subject is a characterization of observed data and related information.
        /// </summary>
        ObservedData,

        /// <summary>
        ///     Report subject is a characterization of one or more threat actors and related information.
        /// </summary>
        ThreatActor,

        /// <summary>
        ///     Report subject is a broad characterization of a threat across multiple facets.
        /// </summary>
        ThreatReport,

        /// <summary>
        ///     Report subject is a characterization of one or more tools and related information.
        /// </summary>
        Tool,

        /// <summary>
        ///     Report subject is a characterization of one or more vulnerabilities and related information.
        /// </summary>
        Vulnerability
    }

    private const string TYPE = "report-type-ov";

    public ReportType(EReportType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}