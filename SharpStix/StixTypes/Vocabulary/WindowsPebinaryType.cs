using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using System.Text.Json.Serialization;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<WindowsPebinaryType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPebinaryType(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "windows-pebinary-type-ov";

    public enum EWindowsPebinaryType
    {
        /// <summary>
        ///     Specifies that the PE binary is a dynamically linked library (DLL).
        /// </summary>
        Dll,

        /// <summary>
        ///     Specifies that the PE binary is an executable image (i.e., not an OBJ or DLL).
        /// </summary>
        Exe,

        /// <summary>
        ///     Specifies that the PE binary is a device driver (SYS).
        /// </summary>
        Sys
    }

    public WindowsPebinaryType(EWindowsPebinaryType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}