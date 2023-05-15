using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<GroupingContext>))]
[StixTypeDiscriminator(TYPE)]
public sealed record GroupingContext : StixOpenVocab, IFromString<GroupingContext>
{
    private const string TYPE = "grouping-context-ov";
    public static readonly GroupingContext SuspiciousActivity = FromString("suspicious-activity");

    public static readonly GroupingContext MalwareAnalysis = FromString("malware-analysis");

    public static readonly GroupingContext Unspecified = FromString("unspecified");

    private GroupingContext(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static GroupingContext FromString(string value)
    {
        if (OpenVocabManager<GroupingContext>.TryGetValue(value, out GroupingContext? vocab))
            return vocab!;

        vocab = new GroupingContext(value);
        OpenVocabManager<GroupingContext>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}