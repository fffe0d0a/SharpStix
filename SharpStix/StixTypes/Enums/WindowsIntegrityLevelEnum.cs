using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsIntegrityLevelEnum : Enumeration<WindowsIntegrityLevelEnum>, IStixEnum
{
    private const string TYPE = "windows-integrity-level-enum";

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

    public string Type => TYPE;
}