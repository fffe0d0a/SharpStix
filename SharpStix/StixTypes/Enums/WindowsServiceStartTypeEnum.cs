using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsServiceStartTypeEnum : Enumeration<WindowsServiceStartTypeEnum>, IStixEnum
{
    private const string TYPE = "windows-service-start-type-enum";

    public readonly static WindowsServiceStartTypeEnum AutoStart =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_AUTO_START);

    public readonly static WindowsServiceStartTypeEnum BootStart =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_BOOT_START);

    public readonly static WindowsServiceStartTypeEnum DemandStart =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_DEMAND_START);

    public readonly static WindowsServiceStartTypeEnum Disabled =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_DISABLED);

    public readonly static WindowsServiceStartTypeEnum SystemAlert =
        new WindowsServiceStartTypeEnum(EWindowsServiceStartType.SERVICE_SYSTEM_ALERT);

    private WindowsServiceStartTypeEnum(EWindowsServiceStartType value) : base(value)
    {
    }

    public string Type => TYPE;

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
}