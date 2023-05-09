using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsIntegrityLevelEnum : Enumeration<WindowsIntegrityLevelEnum>, IStixEnum
{
    private const string TYPE = "windows-integrity-level-enum";

    public readonly static WindowsIntegrityLevelEnum Low = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.Low);

    public readonly static WindowsIntegrityLevelEnum Medium =
        new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.Medium);

    public readonly static WindowsIntegrityLevelEnum High = new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.High);

    public readonly static WindowsIntegrityLevelEnum System =
        new WindowsIntegrityLevelEnum(EWindowsIntegrityLevel.System);

    private WindowsIntegrityLevelEnum(EWindowsIntegrityLevel value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum EWindowsIntegrityLevel
    {
        Low,
        Medium,
        High,
        System
    }
}