using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsServiceStartTypeEnum : Enumeration<WindowsServiceStartTypeEnum>, IStixEnum
{
    private const string TYPE = "windows-service-start-type-enum";

    public static readonly WindowsServiceStartTypeEnum AutoStart = 
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_AUTO_START);

    public static readonly WindowsServiceStartTypeEnum BootStart =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_BOOT_START);

    public static readonly WindowsServiceStartTypeEnum DemandStart =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_DEMAND_START);

    public static readonly WindowsServiceStartTypeEnum Disabled =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_DISABLED);

    public static readonly WindowsServiceStartTypeEnum SystemAlert =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_SYSTEM_ALERT);

    private enum EWindowsServiceStartType
    {
        // ReSharper disable InconsistentNaming

        SERVICE_AUTO_START,
        SERVICE_BOOT_START,
        SERVICE_DEMAND_START,
        SERVICE_DISABLED,
        SERVICE_SYSTEM_ALERT

        // ReSharper restore InconsistentNaming
    }

    private WindowsServiceStartTypeEnum(EWindowsServiceStartType value) : base(value)
    {
    }

    public string Type => TYPE;
}