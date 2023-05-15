using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ImplementationLanguage>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ImplementationLanguage : StixOpenVocab, IFromString<ImplementationLanguage>
{
    private const string TYPE = "implementation-language-ov";
    public static readonly ImplementationLanguage AppleScript = FromString("applescript");

    public static readonly ImplementationLanguage Bash = FromString("bash");

    public static readonly ImplementationLanguage C = FromString("c");

    public static readonly ImplementationLanguage CPlusPlus = FromString("c++");

    public static readonly ImplementationLanguage CSharp = FromString("c#");

    public static readonly ImplementationLanguage Go = FromString("go");

    public static readonly ImplementationLanguage Java = FromString("java");

    public static readonly ImplementationLanguage JavaScript = FromString("javascript");

    public static readonly ImplementationLanguage LUA = FromString("lua");

    public static readonly ImplementationLanguage ObjectiveC = FromString("objective-c");

    public static readonly ImplementationLanguage Perl = FromString("perl");

    public static readonly ImplementationLanguage PHP = FromString("php");

    public static readonly ImplementationLanguage Powershell = FromString("powershell");

    public static readonly ImplementationLanguage Python = FromString("python"); //yuck

    public static readonly ImplementationLanguage Ruby = FromString("ruby");

    public static readonly ImplementationLanguage Scala = FromString("scala");

    public static readonly ImplementationLanguage Swift = FromString("swift");

    public static readonly ImplementationLanguage TypeScript = FromString("typescript");

    public static readonly ImplementationLanguage VisualBasic = FromString("visual-basic");

    public static readonly ImplementationLanguage X86_32 = FromString("x86-32");

    public static readonly ImplementationLanguage X86_64 = FromString("x86-64");

    private ImplementationLanguage(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ImplementationLanguage FromString(string value)
    {
        if (OpenVocabManager<ImplementationLanguage>.TryGetValue(value, out ImplementationLanguage? vocab))
            return vocab!;

        vocab = new ImplementationLanguage(value);
        OpenVocabManager<ImplementationLanguage>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}