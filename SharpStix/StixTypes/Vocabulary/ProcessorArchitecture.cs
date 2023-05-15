using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ProcessorArchitecture>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ProcessorArchitecture : StixOpenVocab, IFromString<ProcessorArchitecture>
{
    private const string TYPE = "processor-architecture-ov";
    public static readonly ProcessorArchitecture Alpha = FromString("alpha");

    public static readonly ProcessorArchitecture Arm = FromString("arm");

    public static readonly ProcessorArchitecture IA_64 = FromString("ia_64");

    public static readonly ProcessorArchitecture Mips = FromString("mips");

    public static readonly ProcessorArchitecture PowerPc = FromString("powerpc");

    public static readonly ProcessorArchitecture Sparc = FromString("sparc");

    public static readonly ProcessorArchitecture X86 = FromString("x86");

    public static readonly ProcessorArchitecture x86_64 = FromString("x86-64");

    private ProcessorArchitecture(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static ProcessorArchitecture FromString(string value)
    {
        if (OpenVocabManager<ProcessorArchitecture>.TryGetValue(value, out ProcessorArchitecture? vocab))
            return vocab!;

        vocab = new ProcessorArchitecture(value);
        OpenVocabManager<ProcessorArchitecture>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}