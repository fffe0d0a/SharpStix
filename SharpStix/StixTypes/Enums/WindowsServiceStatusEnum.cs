using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsServiceStatusEnum : Enumeration<WindowsServiceStatusEnum>, IStixEnum
{
    private const string TYPE = "windows-service-status-enum";

    public readonly static WindowsServiceStatusEnum ContinuePending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_CONTINUE_PENDING);

    public readonly static WindowsServiceStatusEnum PausePending
        = new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_PAUSE_PENDING);

    public readonly static WindowsServiceStatusEnum Paused =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_PAUSED);

    public readonly static WindowsServiceStatusEnum Running =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_RUNNING);

    public readonly static WindowsServiceStatusEnum StartPending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_START_PENDING);

    public readonly static WindowsServiceStatusEnum StopPending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_STOP_PENDING);

    public readonly static WindowsServiceStatusEnum Stopped =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_STOPPED);

    private WindowsServiceStatusEnum(EWindowsServiceStatus value) : base(value)
    {
    }

    public string Type => TYPE;

    private enum EWindowsServiceStatus
    {
        // ReSharper disable InconsistentNaming

        SERVICE_CONTINUE_PENDING,
        SERVICE_PAUSE_PENDING,
        SERVICE_PAUSED,
        SERVICE_RUNNING,
        SERVICE_START_PENDING,
        SERVICE_STOP_PENDING,
        SERVICE_STOPPED

        // ReSharper restore InconsistentNaming
    }
}