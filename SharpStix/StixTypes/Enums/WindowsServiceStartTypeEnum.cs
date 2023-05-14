using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record WindowsServiceStartTypeEnum : Enumeration<WindowsServiceStartTypeEnum>, IStixEnum
{
    private const string TYPE = "windows-service-start-type-enum";

    public static readonly WindowsServiceStartTypeEnum AutoStart =
        new WindowsServiceStartTypeEnum(0, "SERVICE_AUTO_START");

    public static readonly WindowsServiceStartTypeEnum BootStart =
        new WindowsServiceStartTypeEnum(1, "SERVICE_BOOT_START");

    public static readonly WindowsServiceStartTypeEnum DemandStart =
        new WindowsServiceStartTypeEnum(2, "SERVICE_DEMAND_START");

    public static readonly WindowsServiceStartTypeEnum Disabled =
        new WindowsServiceStartTypeEnum(3, "SERVICE_DISABLED");

    public static readonly WindowsServiceStartTypeEnum SystemAlert =
        new WindowsServiceStartTypeEnum(4, "SERVICE_SYSTEM_ALERT");

    private WindowsServiceStartTypeEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;

    public override string ToString() => base.ToString();
}