using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ImplementationLanguage>))]
public sealed record ImplementationLanguage(string Value) : StixOpenVocab(Value)
{
    public enum EImplementationLanguage
    {
        Applescript,
        Bash,
        C,
        CPlusPlus,
        CSharp,
        Go,
        Java,
        Javscript,
        Lua,
        ObjectiveC,
        Perl,
        Php,
        Powershell,
        Python,
        Ruby,
        Scala,
        Swift,
        Typescript,
        VisualBasic,

        // ReSharper disable InconsistentNaming
        /// <summary>
        ///     Specifies the x86 32-bit Assembly programming language.
        /// </summary>
        x86_32,

        /// <summary>
        ///     Specifies the x86 64-bit Assembly programming language.
        /// </summary>
        x86_64
        // ReSharper restore InconsistentNaming
    }

    public ImplementationLanguage(EImplementationLanguage value) : this(FormatEImplementationLanguage(value))
    {
    }

    private static string FormatEImplementationLanguage(EImplementationLanguage language)
    {
        switch (language)
        {
            case EImplementationLanguage.Applescript:
            case EImplementationLanguage.Bash:
            case EImplementationLanguage.C:
            case EImplementationLanguage.Go:
            case EImplementationLanguage.Java:
            case EImplementationLanguage.Javscript:
            case EImplementationLanguage.Lua:
            case EImplementationLanguage.Perl:
            case EImplementationLanguage.Php:
            case EImplementationLanguage.Powershell:
            case EImplementationLanguage.Python:
            case EImplementationLanguage.Ruby:
            case EImplementationLanguage.Scala:
            case EImplementationLanguage.Swift:
            case EImplementationLanguage.Typescript:
            case EImplementationLanguage.VisualBasic:
            case EImplementationLanguage.ObjectiveC:
                return language.ToString().PascalToKebabCase();
            case EImplementationLanguage.CPlusPlus:
                return "c++";
            case EImplementationLanguage.CSharp:
                return "c#";
            case EImplementationLanguage.x86_32:
                return "x86-32";
            case EImplementationLanguage.x86_64:
                return "x86-64";
            default:
                throw new ArgumentOutOfRangeException(nameof(language), language, "Unhandled switch case.");
        }
    }

    public new static string TypeName => "implementation-language-ov";
}