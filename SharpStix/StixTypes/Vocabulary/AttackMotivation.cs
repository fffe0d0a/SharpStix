using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackMotivation>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackMotivation(string Value) : StixOpenVocab(Value)
{
    public static readonly AttackMotivation Accidental = new AttackMotivation("accidental");

    public static readonly AttackMotivation Coercion = new AttackMotivation("coercion");

    public static readonly AttackMotivation Dominance = new AttackMotivation("dominance");

    public static readonly AttackMotivation Ideology = new AttackMotivation("ideology");

    public static readonly AttackMotivation Notoriety = new AttackMotivation("notoriety");

    public static readonly AttackMotivation OrganisationalGain = new AttackMotivation("organizational-gain");

    public static readonly AttackMotivation PersonalGain = new AttackMotivation("personal-gain");

    public static readonly AttackMotivation PersonalSatisfaction = new AttackMotivation("personal-satisfaction");

    public static readonly AttackMotivation Revenge = new AttackMotivation("revenge");

    public static readonly AttackMotivation Unpredictable = new AttackMotivation("unpredictable");

    private const string TYPE = "attack-motivation-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}