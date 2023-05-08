using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<ProcessorArchitecture>))]
[StixTypeDiscriminator(TYPE)]
public sealed record ProcessorArchitecture(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "processor-architecture-ov";

    public enum EProcessorArchitecture
    {
        /// <summary>
        ///     Specifies the Alpha architecture.
        /// </summary>
        Alpha,

        /// <summary>
        ///     Specifies the ARM architecture.
        /// </summary>
        Arm,

        /// <summary>
        ///     Specifies the 64-bit IA (Itanium) architecture.
        /// </summary>
        Ia_64,

        /// <summary>
        ///     Specifies the MIPS architecture.
        /// </summary>
        Mips,

        /// <summary>
        ///     Specifies the PowerPC architecture.
        /// </summary>
        Powerpc,

        /// <summary>
        ///     Specifies the SPARC architecture.
        /// </summary>
        Sparc,

        /// <summary>
        ///     Specifies the 32-bit x86 architecture.
        /// </summary>
        x86,

        /// <summary>
        ///     Specifies the 64-bit x86 architecture.
        /// </summary>
        x86_64
    }

    public ProcessorArchitecture(EProcessorArchitecture value) : this(FormatEProcessorArchitecture(value))
    {
    }

    private static string FormatEProcessorArchitecture(EProcessorArchitecture processorArchitecture)
    {
        switch (processorArchitecture)
        {
            case EProcessorArchitecture.Alpha:
            case EProcessorArchitecture.Arm:
            case EProcessorArchitecture.Mips:
            case EProcessorArchitecture.Powerpc:
            case EProcessorArchitecture.Sparc:
            case EProcessorArchitecture.x86:
                return processorArchitecture.ToString().PascalToKebabCase();
            case EProcessorArchitecture.Ia_64:
            case EProcessorArchitecture.x86_64:
                return processorArchitecture.ToString().ToLowerInvariant().Replace('_', '-');
            default:
                throw new ArgumentOutOfRangeException(nameof(processorArchitecture), processorArchitecture,
                    "Unhandled switch argument.");
        }
    }

    public override string Type => TYPE;
}