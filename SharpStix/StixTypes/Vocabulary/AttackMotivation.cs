using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackMotivation>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackMotivation(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "attack-motivation-ov";

    public enum EAttackMotivation
    {
        /// <summary>
        ///     A non-hostile actor whose benevolent or harmless intent inadvertently causes harm.
        /// </summary>
        Accidental,

        /// <summary>
        ///     Being forced to act on someone else's behalf.
        /// </summary>
        Coercion,

        /// <summary>
        ///     A desire to assert superiority over someone or something else.
        /// </summary>
        Dominance,

        /// <summary>
        ///     A passion to express a set of ideas, beliefs, and values that may shape and drive harmful and illegal acts.
        /// </summary>
        Ideology,

        /// <summary>
        ///     Seeking prestige or to become well known through some activity.
        /// </summary>
        Notoriety,

        /// <summary>
        ///     Seeking advantage over a competing organization, including a military organization.
        /// </summary>
        OrganizationalGain,

        /// <summary>
        ///     The desire to improve one’s own financial status.
        /// </summary>
        PersonalGain,

        /// <summary>
        ///     A desire to satisfy a strictly personal goal, including curiosity, thrill-seeking, amusement, etc.
        /// </summary>
        PersonalSatisfaction,

        /// <summary>
        ///     A desire to avenge perceived wrongs through harmful actions such as sabotage, violence, theft, fraud, or
        ///     embarrassing certain individuals or the organization.
        /// </summary>
        Revenge,

        /// <summary>
        ///     Acting without identifiable reason or purpose and creating unpredictable events.
        /// </summary>
        Unpredictable
    }

    public AttackMotivation(EAttackMotivation value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}