using SharpStix.Common;

namespace SharpStix.StixTypes.Enums;

public sealed record WindowsIntegrityLevelEnum : Enumeration<WindowsIntegrityLevelEnum>, IStixEnum
{
    public static readonly WindowsIntegrityLevelEnum Low = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.Low);

    public static readonly WindowsIntegrityLevelEnum Medium = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.Medium);

    public static readonly WindowsIntegrityLevelEnum High = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.High);

    public static readonly WindowsIntegrityLevelEnum System = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.System);

    private enum EWindowsIntegrityLevel
    {
        Low,
        Medium,
        High,
        System
    }

    private WindowsIntegrityLevelEnum(EWindowsIntegrityLevel value) : base(value)
    {
    }

    public static string TypeName => "windows-integrity-level-enum";
}