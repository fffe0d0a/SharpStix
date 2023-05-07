using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record PatternType(string Value) : StixOpenVocab(Value)
{
    public enum EPatternType
    {
        /// <summary>
        ///     Specifies the STIX pattern language.
        /// </summary>
        Stix,

        /// <summary>
        ///     Specifies the Perl Compatible Regular Expressions language.
        /// </summary>
        Pcre,

        /// <summary>
        ///     Specifies the SIGMA language.
        /// </summary>
        Sigma,

        /// <summary>
        ///     Specifies the SNORT language.
        /// </summary>
        Snort,

        /// <summary>
        ///     Specifies the SURICATA language.
        /// </summary>
        Suricata,

        /// <summary>
        ///     Specifies the YARA language.
        /// </summary>
        Yara
    }

    public PatternType(EPatternType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public new static string TypeName => "pattern-type-ov";
}