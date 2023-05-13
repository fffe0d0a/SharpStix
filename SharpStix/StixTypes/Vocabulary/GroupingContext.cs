using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<GroupingContext>))]
[StixTypeDiscriminator(TYPE)]
public sealed record GroupingContext(string Value) : StixOpenVocab(Value)
{
    public static readonly GroupingContext SuspiciousActivity = new GroupingContext("suspicious-activity");

    public static readonly GroupingContext MalwareAnalysis = new GroupingContext("malware-analysis");

    public static readonly GroupingContext Unspecified = new GroupingContext("unspecified");

    private const string TYPE = "grouping-context-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}