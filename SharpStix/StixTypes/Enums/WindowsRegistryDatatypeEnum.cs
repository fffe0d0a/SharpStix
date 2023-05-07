using SharpStix.Common;

namespace SharpStix.StixTypes.Enums;

public sealed record WindowsRegistryDatatypeEnum : Enumeration<WindowsRegistryDatatypeEnum>, IStixEnum
{
    public static readonly WindowsRegistryDatatypeEnum None =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_NONE);

    public static readonly WindowsRegistryDatatypeEnum String =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_SZ);

    public static readonly WindowsRegistryDatatypeEnum ExpandString =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_EXPAND_SZ);

    public static readonly WindowsRegistryDatatypeEnum Binary =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_BINARY);

    public static readonly WindowsRegistryDatatypeEnum DWord =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD);

    public static readonly WindowsRegistryDatatypeEnum DWordBigEndian =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD_BIG_ENDIAN);

    public static readonly WindowsRegistryDatatypeEnum DWordLittleEndian =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_DWORD_LITTLE_ENDIAN);

    public static readonly WindowsRegistryDatatypeEnum Link =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_LINK);

    public static readonly WindowsRegistryDatatypeEnum MultiString =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_MULTI_SZ);

    public static readonly WindowsRegistryDatatypeEnum ResourceList =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_RESOURCE_LIST);

    public static readonly WindowsRegistryDatatypeEnum FullResourceDescription =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_FULL_RESOURCE_DESCRIPTION);

    public static readonly WindowsRegistryDatatypeEnum ResourceRequirementsList =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_RESOURCE_REQUIREMENTS_LIST);

    public static readonly WindowsRegistryDatatypeEnum QWord =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_QWORD);

    public static readonly WindowsRegistryDatatypeEnum Invalid =
        new WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype.REG_INVALID_TYPE);

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

    private WindowsRegistryDatatypeEnum(EWindowsRegistryDatatype value) : base(value)
    {
    }

    public static string TypeName => "windows-registry-datatype-enum";
}