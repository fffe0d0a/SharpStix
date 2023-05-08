using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AttackResourceLevel>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AttackResourceLevel(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "attack-resource-level-ov";

    public enum EAttackResourceLevel
    {
        /// <summary>
        ///     Resources limited to the average individual; Threat Actor acts independently.
        /// </summary>
        Individual,

        /// <summary>
        ///     Members interact on a social and volunteer basis, often with little personal interest in the specific target.
        /// </summary>
        Club,

        /// <summary>
        ///     A short-lived and perhaps anonymous interaction that concludes when the participants have achieved a single goal.
        /// </summary>
        Contest,

        /// <summary>
        ///     A formally organized group with a leader, typically motivated by a specific goal and organized around that goal.
        /// </summary>
        Team,

        /// <summary>
        ///     Larger and better resourced than a team; typically, a company or crime syndicate. Usually operates in multiple
        ///     geographic areas and persists long term.
        /// </summary>
        Organization,

        /// <summary>
        ///     Controls public assets and functions within a jurisdiction; very well resourced and persists long term.
        /// </summary>
        Government
    }

    public AttackResourceLevel(EAttackResourceLevel value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}