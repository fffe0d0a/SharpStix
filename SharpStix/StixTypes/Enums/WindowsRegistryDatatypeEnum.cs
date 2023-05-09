using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsRegistryDatatypeEnum : Enumeration<WindowsRegistryDatatypeEnum>, IStixEnum
{
    private const string TYPE = "windows-registry-datatype-enum";

    public readonly static WindowsRegistryDatatypeEnum None =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_NONE);

    public readonly static WindowsRegistryDatatypeEnum String =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_SZ);

    public readonly static WindowsRegistryDatatypeEnum ExpandString =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_EXPAND_SZ);

    public readonly static WindowsRegistryDatatypeEnum Binary =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_BINARY);

    public readonly static WindowsRegistryDatatypeEnum DWord =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD);

    public readonly static WindowsRegistryDatatypeEnum DWordBigEndian =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD_BIG_ENDIAN);

    public readonly static WindowsRegistryDatatypeEnum DWordLittleEndian =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD_LITTLE_ENDIAN);

    public readonly static WindowsRegistryDatatypeEnum Link =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_LINK);

    public readonly static WindowsRegistryDatatypeEnum MultiString =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_MULTI_SZ);

    public readonly static WindowsRegistryDatatypeEnum ResourceList =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_RESOURCE_LIST);

    public readonly static WindowsRegistryDatatypeEnum FullResourceDescription =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_FULL_RESOURCE_DESCRIPTION);

    public readonly static WindowsRegistryDatatypeEnum ResourceRequirementsList =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_RESOURCE_REQUIREMENTS_LIST);

    public readonly static WindowsRegistryDatatypeEnum QWord =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_QWORD);

    public readonly static WindowsRegistryDatatypeEnum Invalid =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_INVALID_TYPE);

    private WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum EWindowsRegistryDatatype
    {
        // ReSharper disable InconsistentNaming

        REG_NONE,
        REG_SZ,
        REG_EXPAND_SZ,
        REG_BINARY,
        REG_DWORD,
        REG_DWORD_BIG_ENDIAN,
        REG_DWORD_LITTLE_ENDIAN,
        REG_LINK,
        REG_MULTI_SZ,
        REG_RESOURCE_LIST,
        REG_FULL_RESOURCE_DESCRIPTION,
        REG_RESOURCE_REQUIREMENTS_LIST,
        REG_QWORD,
        REG_INVALID_TYPE

        // ReSharper restore InconsistentNaming
    }
}