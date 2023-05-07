using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record IdentityClass(string Value) : StixOpenVocab(Value)
{
    public enum EIdentityClass
    {
        /// <summary>
        ///     A single person.
        /// </summary>
        Individual,

        /// <summary>
        ///     An informal collection of people, without formal governance, such as a distributed hacker group.
        /// </summary>
        Group,

        /// <summary>
        ///     A computer system, such as a SIEM.
        /// </summary>
        System,

        /// <summary>
        ///     A formal organization of people, with governance, such as a company or country.
        /// </summary>
        Organization,

        /// <summary>
        ///     A class of entities, such as all hospitals, all Europeans, or the Domain Administrators in a system.
        /// </summary>
        Class,

        /// <summary>
        ///     It is unknown whether the classification is an individual, group, system, organization, or class.
        /// </summary>
        Unknown
    }

    public IdentityClass(EIdentityClass value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "identity-class-ov";
}