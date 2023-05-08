using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<IndicatorType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record IndicatorType(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "indicator-type-ov";

    public enum EIndicatorType
    {
        /// <summary>
        ///     Unexpected, or unusual activity that may not necessarily be malicious or indicate compromise.
        /// </summary>
        AnomalousActivity,

        /// <summary>
        ///     Suspected anonymization tools or infrastructure (proxy, TOR, VPN, etc.).
        /// </summary>
        Anonymization,

        /// <summary>
        ///     Activity that is not suspicious or malicious in and of itself, but when combined with other activity may indicate
        ///     suspicious or malicious behaviour.
        /// </summary>
        Benign,

        /// <summary>
        ///     Assets that are suspected to be compromised.
        /// </summary>
        Compromised,

        /// <summary>
        ///     Patterns of suspected malicious objects and/or activity.
        /// </summary>
        MaliciousActivity,

        /// <summary>
        ///     Patterns of behavior that indicate attribution to a particular Threat Actor or Campaign.
        /// </summary>
        Attribution,

        /// <summary>
        ///     There is not enough information available to determine the type of indicator.
        /// </summary>
        Unknown
    }

    public IndicatorType(EIndicatorType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}