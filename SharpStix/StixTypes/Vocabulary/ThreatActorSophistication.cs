using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record ThreatActorSophistication(string Value) : StixOpenVocab(Value)
{
    public enum EThreatActorSophistication
    {
        /// <summary>
        ///     Can carry out random acts of disruption or destruction by running tools they do not understand. Actors in this
        ///     category have average computer skills.
        /// </summary>
        None,

        /// <summary>
        ///     Can minimally use existing and frequently well known and easy-to-find techniques and programs or scripts to search
        ///     for and exploit weaknesses in other computers. Commonly referred to as a script-kiddie.
        /// </summary>
        Minimal,

        /// <summary>
        ///     Can proficiently use existing attack frameworks and toolkits to search for and exploit vulnerabilities in computers
        ///     or systems. Actors in this category have computer skills equivalent to an IT professional and typically have a
        ///     working knowledge of networks, operating systems, and possibly even defensive techniques and will typically exhibit
        ///     some operational security.
        /// </summary>
        Intermediate,

        /// <summary>
        ///     Can develop their own tools or scripts from publicly known vulnerabilities to target systems and users. Actors in
        ///     this category are very adept at IT systems and have a background in software development along with a solid
        ///     understanding of defensive techniques and operational security.
        /// </summary>
        Advanced,

        /// <summary>
        ///     Can focus on the discovery and use of unknown malicious code, is adept at installing user and kernel mode rootkits,
        ///     frequently use data mining tools, target corporate executives and key users (government and industry) for the
        ///     purpose of stealing personal and corporate data. Actors in this category are very adept at IT systems and software
        ///     development and are experts with security systems, defensive techniques, attack methods, and operational security.
        /// </summary>
        Expert,

        /// <summary>
        ///     Typically, criminal or state actors who are organized, highly technical, proficient, well-funded professionals
        ///     working in teams to discover new vulnerabilities and develop exploits.
        /// </summary>
        Innovator,

        /// <summary>
        ///     State actors who create vulnerabilities through an active program to "influence" commercial products and services
        ///     during design, development or manufacturing, or with the ability to impact products while in the supply chain to
        ///     enable exploitation of networks and systems of interest.
        /// </summary>
        Strategic
    }

    public ThreatActorSophistication(EThreatActorSophistication value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "threat-actor-sophistication-ov";
}