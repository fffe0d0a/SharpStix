using SharpStix.Common;

namespace SharpStix.StixTypes.Enums;

public sealed record WindowsServiceStatusEnum : Enumeration<WindowsServiceStatusEnum>, IStixEnum
{
    public static readonly WindowsServiceStatusEnum ContinuePending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_CONTINUE_PENDING);

    public static readonly WindowsServiceStatusEnum PausePending
        = new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_PAUSE_PENDING);

    public static readonly WindowsServiceStatusEnum Paused =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_PAUSED);

    public static readonly WindowsServiceStatusEnum Running =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_RUNNING);

    public static readonly WindowsServiceStatusEnum StartPending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_START_PENDING);

    public static readonly WindowsServiceStatusEnum StopPending =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_STOP_PENDING);

    public static readonly WindowsServiceStatusEnum Stopped =
        new WindowsServiceStatusEnum(EWindowsServiceStatus.SERVICE_STOPPED);

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

    private WindowsServiceStatusEnum(EWindowsServiceStatus value) : base(value)
    {
    }

    public static string TypeName => "windows-service-status-enum";
}