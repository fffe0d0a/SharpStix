using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

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

    public GroupingContext(EGroupingContext value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "grouping-context-ov";
}