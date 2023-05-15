using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackResourceLevel>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackResourceLevel : StixOpenVocab, IFromString<AttackResourceLevel>
{
    private const string TYPE = "attack-resource-level-ov";
    public static readonly AttackResourceLevel Individual = FromString("individual");

    public static readonly AttackResourceLevel Club = FromString("club");

    public static readonly AttackResourceLevel Contest = FromString("contest");

    public static readonly AttackResourceLevel Team = FromString("team");

    public static readonly AttackResourceLevel Organisation = FromString("organization");

    public static readonly AttackResourceLevel Government = FromString("government");

    private AttackResourceLevel(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static AttackResourceLevel FromString(string value)
    {
        if (OpenVocabManager<AttackResourceLevel>.TryGetValue(value, out AttackResourceLevel? vocab))
            return vocab!;

        vocab = new AttackResourceLevel(value);
        OpenVocabManager<AttackResourceLevel>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}