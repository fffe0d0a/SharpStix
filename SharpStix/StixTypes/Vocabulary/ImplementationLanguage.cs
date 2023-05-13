using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ImplementationLanguage>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ImplementationLanguage(string Value) : StixOpenVocab(Value)
{
    public static readonly ImplementationLanguage AppleScript = new ImplementationLanguage("applescript");

    public static readonly ImplementationLanguage Bash = new ImplementationLanguage("bash");

    public static readonly ImplementationLanguage C = new ImplementationLanguage("c");

    public static readonly ImplementationLanguage CPlusPlus = new ImplementationLanguage("c++");

    public static readonly ImplementationLanguage CSharp = new ImplementationLanguage("c#");

    public static readonly ImplementationLanguage Go = new ImplementationLanguage("go");

    public static readonly ImplementationLanguage Java = new ImplementationLanguage("java");

    public static readonly ImplementationLanguage JavaScript = new ImplementationLanguage("javascript");

    public static readonly ImplementationLanguage LUA = new ImplementationLanguage("lua");

    public static readonly ImplementationLanguage ObjectiveC = new ImplementationLanguage("objective-c");

    public static readonly ImplementationLanguage Perl = new ImplementationLanguage("perl");

    public static readonly ImplementationLanguage PHP = new ImplementationLanguage("php");

    public static readonly ImplementationLanguage Powershell = new ImplementationLanguage("powershell");

    public static readonly ImplementationLanguage Python = new ImplementationLanguage("python"); //yuck

    public static readonly ImplementationLanguage Ruby = new ImplementationLanguage("ruby");

    public static readonly ImplementationLanguage Scala = new ImplementationLanguage("scala");

    public static readonly ImplementationLanguage Swift = new ImplementationLanguage("swift");

    public static readonly ImplementationLanguage TypeScript = new ImplementationLanguage("typescript");

    public static readonly ImplementationLanguage VisualBasic = new ImplementationLanguage("visual-basic");

    public static readonly ImplementationLanguage X86_32 = new ImplementationLanguage("x86-32");

    public static readonly ImplementationLanguage X86_64 = new ImplementationLanguage("x86-64");


    private const string TYPE = "implementation-language-ov";
    
    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}