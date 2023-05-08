using System.Text.Json.Serialization;
using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<GroupingContext>))]
[StixTypeDiscriminator(TYPE)]
public sealed record GroupingContext(string Value) : StixOpenVocab(Value)
{
    public enum EGroupingContext
    {
        /// <summary>
        ///     A set of STIX content related to a particular suspicious activity event.
        /// </summary>
        SuspiciousActivity,

        /// <summary>
        ///     A set of STIX content related to a particular malware instance or family.
        /// </summary>
        MalwareAnalysis,

        /// <summary>
        ///     A set of STIX content contextually related but without any precise characterization of the contextual relationship
        ///     between the objects.
        /// </summary>
        Unspecified
    }

    private const string TYPE = "grouping-context-ov";

    public GroupingContext(EGroupingContext value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}