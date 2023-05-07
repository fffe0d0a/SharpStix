using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ThreatActorType>))]
public sealed record ThreatActorType(string Value) : StixOpenVocab(Value)
{
    public enum EThreatActorType
    {
        /// <summary>
        ///     Highly motivated, potentially destructive supporter of a social or political cause (e.g., trade, labor,
        ///     environment, etc.) that attempts to disrupt an organization's business model or damage their image.
        /// </summary>
        Activist,

        /// <summary>
        ///     An organization that competes in the same economic marketplace.
        /// </summary>
        Competitor,

        /// <summary>
        ///     An enterprise organized to conduct significant, large-scale criminal activity for profit.
        /// </summary>
        CrimeSyndicate,

        /// <summary>
        ///     Individual who commits computer crimes, often for personal financial gain and often involves the theft of something
        ///     valuable.
        /// </summary>
        Criminal,

        /// <summary>
        ///     An individual that tends to break into networks for the thrill or the challenge of doing so.
        /// </summary>
        Hacker,

        /// <summary>
        ///     A non-hostile insider who unintentionally exposes the organization to harm.
        /// </summary>
        InsiderAccidental,

        /// <summary>
        ///     Current or former insiders who seek revengeful and harmful retaliation for perceived wrongs.
        /// </summary>
        InsiderDisgruntled,

        /// <summary>
        ///     Entities who work for the government or military of a nation state or who work at their direction.
        /// </summary>
        NationState,

        /// <summary>
        ///     Seeks to cause embarrassment and brand damage by exposing sensitive information in a manner designed to cause a
        ///     public relations crisis.
        /// </summary>
        Sensationalist,

        /// <summary>
        ///     Secretly collects sensitive information for use, dissemination, or sale.
        /// </summary>
        Spy,

        /// <summary>
        ///     Uses extreme violence to advance a social or political agenda as well as monetary crimes to support its activities.
        /// </summary>
        Terrorist,

        /// <summary>
        ///     There is not enough information available to determine the type of threat actor.
        /// </summary>
        Unknown
    }

    public ThreatActorType(EThreatActorType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "threat-actor-type-ov";
}