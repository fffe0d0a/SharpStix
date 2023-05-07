using SharpStix.Extensions;

namespace SharpStix.StixTypes.Vocabulary;

public sealed record WindowsPebinaryType(string Value) : StixOpenVocab(Value)
{
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

    public new static string TypeName => "windows-pebinary-type-ov";
}