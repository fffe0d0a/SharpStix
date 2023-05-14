using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackResourceLevel>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackResourceLevel(string Value) : StixOpenVocab(Value)
{
    public static readonly AttackResourceLevel Individual = new AttackResourceLevel("individual");

    public static readonly AttackResourceLevel Club = new AttackResourceLevel("club");

    public static readonly AttackResourceLevel Contest = new AttackResourceLevel("contest");

    public static readonly AttackResourceLevel Team = new AttackResourceLevel("team");

    public static readonly AttackResourceLevel Organisation = new AttackResourceLevel("organization");

    public static readonly AttackResourceLevel Government = new AttackResourceLevel("government");

    private const string TYPE = "attack-resource-level-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}