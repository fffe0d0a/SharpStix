using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ProcessorArchitecture>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ProcessorArchitecture(string Value) : StixOpenVocab(Value)
{
    public static readonly ProcessorArchitecture Alpha = new ProcessorArchitecture("alpha");

    public static readonly ProcessorArchitecture Arm = new ProcessorArchitecture("arm");

    public static readonly ProcessorArchitecture IA_64 = new ProcessorArchitecture("ia_64");

    public static readonly ProcessorArchitecture Mips = new ProcessorArchitecture("mips");

    public static readonly ProcessorArchitecture PowerPc = new ProcessorArchitecture("powerpc");

    public static readonly ProcessorArchitecture Sparc = new ProcessorArchitecture("sparc");

    public static readonly ProcessorArchitecture X86 = new ProcessorArchitecture("x86");

    public static readonly ProcessorArchitecture x86_64 = new ProcessorArchitecture("x86-64");

    private const string TYPE = "processor-architecture-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();
}