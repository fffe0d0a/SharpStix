using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackMotivation>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackMotivation : StixOpenVocab, IFromString<AttackMotivation>
{
    private const string TYPE = "attack-motivation-ov";
    public static readonly AttackMotivation Accidental = FromString("accidental");

    public static readonly AttackMotivation Coercion = FromString("coercion");

    public static readonly AttackMotivation Dominance = FromString("dominance");

    public static readonly AttackMotivation Ideology = FromString("ideology");

    public static readonly AttackMotivation Notoriety = FromString("notoriety");

    public static readonly AttackMotivation OrganisationalGain = FromString("organizational-gain");

    public static readonly AttackMotivation PersonalGain = FromString("personal-gain");

    public static readonly AttackMotivation PersonalSatisfaction = FromString("personal-satisfaction");

    public static readonly AttackMotivation Revenge = FromString("revenge");

    public static readonly AttackMotivation Unpredictable = FromString("unpredictable");

    private AttackMotivation(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static AttackMotivation FromString(string value)
    {
        if (OpenVocabManager<AttackMotivation>.TryGetValue(value, out AttackMotivation? vocab))
            return vocab!;

        vocab = new AttackMotivation(value);
        OpenVocabManager<AttackMotivation>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}