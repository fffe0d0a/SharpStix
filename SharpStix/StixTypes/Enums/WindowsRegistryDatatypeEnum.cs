using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record WindowsRegistryDatatypeEnum : Enumeration<WindowsRegistryDatatypeEnum>, IStixEnum
{
    private const string TYPE = "windows-registry-datatype-enum";

    public static readonly WindowsRegistryDatatypeEnum None =
        new WindowsRegistryDatatypeEnum(0, "REG_NONE");

    public static readonly WindowsRegistryDatatypeEnum String =
        new WindowsRegistryDatatypeEnum(1, "REG_SZ");

    public static readonly WindowsRegistryDatatypeEnum ExpandString =
        new WindowsRegistryDatatypeEnum(2, "REG_EXPAND_SZ");

    public static readonly WindowsRegistryDatatypeEnum Binary =
        new WindowsRegistryDatatypeEnum(3, "REG_BINARY");

    public static readonly WindowsRegistryDatatypeEnum DWord =
        new WindowsRegistryDatatypeEnum(4, "REG_DWORD");

    public static readonly WindowsRegistryDatatypeEnum DWordBigEndian =
        new WindowsRegistryDatatypeEnum(5, "REG_DWORD_BIG_ENDIAN");

    public static readonly WindowsRegistryDatatypeEnum DWordLittleEndian =
        new WindowsRegistryDatatypeEnum(6, "REG_DWORD_LITTLE_ENDIAN");

    public static readonly WindowsRegistryDatatypeEnum Link =
        new WindowsRegistryDatatypeEnum(7, "REG_LINK");

    public static readonly WindowsRegistryDatatypeEnum MultiString =
        new WindowsRegistryDatatypeEnum(8, "REG_MULTI_SZ");

    public static readonly WindowsRegistryDatatypeEnum ResourceList =
        new WindowsRegistryDatatypeEnum(9, "REG_RESOURCE_LIST");

    public static readonly WindowsRegistryDatatypeEnum FullResourceDescription =
        new WindowsRegistryDatatypeEnum(10, "REG_FULL_RESOURCE_DESCRIPTION");

    public static readonly WindowsRegistryDatatypeEnum ResourceRequirementsList =
        new WindowsRegistryDatatypeEnum(11, "REG_RESOURCE_REQUIREMENTS_LIST");

    public static readonly WindowsRegistryDatatypeEnum QWord =
        new WindowsRegistryDatatypeEnum(12, "REG_QWORD");

    public static readonly WindowsRegistryDatatypeEnum Invalid =
        new WindowsRegistryDatatypeEnum(13, "REG_INVALID_TYPE");

    private WindowsRegistryDatatypeEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;

    public override string ToString() => base.ToString();
}