using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record WindowsServiceTypeEnum : Enumeration<WindowsServiceTypeEnum>, IStixEnum
{
    private const string TYPE = "windows-service-type-enum";

    public static readonly WindowsServiceTypeEnum KernelDriver =
        new WindowsServiceTypeEnum(0, "SERVICE_KERNEL_DRIVER");

    public static readonly WindowsServiceTypeEnum FileSystemDriver =
        new WindowsServiceTypeEnum(1, "SERVICE_FILE_SYSTEM_DRIVER");

    public static readonly WindowsServiceTypeEnum Win32OwnProcess =
        new WindowsServiceTypeEnum(2, "SERVICE_WIN32_OWN_PROCESS");

    public static readonly WindowsServiceTypeEnum Win32ShareProcess =
        new WindowsServiceTypeEnum(3, "SERVICE_WIN32_SHARE_PROCESS");

    private WindowsServiceTypeEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}