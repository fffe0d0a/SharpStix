using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record WindowsServiceStatusEnum : Enumeration<WindowsServiceStatusEnum>, IStixEnum
{
    private const string TYPE = "windows-service-status-enum";

    public static readonly WindowsServiceStatusEnum ContinuePending =
        new WindowsServiceStatusEnum(0, "SERVICE_CONTINUE_PENDING");

    public static readonly WindowsServiceStatusEnum PausePending
        = new WindowsServiceStatusEnum(1, "SERVICE_PAUSE_PENDING");

    public static readonly WindowsServiceStatusEnum Paused =
        new WindowsServiceStatusEnum(2, "SERVICE_PAUSED");

    public static readonly WindowsServiceStatusEnum Running =
        new WindowsServiceStatusEnum(3, "SERVICE_RUNNING");

    public static readonly WindowsServiceStatusEnum StartPending =
        new WindowsServiceStatusEnum(4, "SERVICE_START_PENDING");

    public static readonly WindowsServiceStatusEnum StopPending =
        new WindowsServiceStatusEnum(5, "SERVICE_STOP_PENDING");

    public static readonly WindowsServiceStatusEnum Stopped =
        new WindowsServiceStatusEnum(6, "SERVICE_STOPPED");

    private WindowsServiceStatusEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;
}