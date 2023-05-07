using SharpStix.Common;

namespace SharpStix.StixTypes.Enums;

public sealed record WindowsServiceTypeEnum : Enumeration<WindowsServiceTypeEnum>, IStixEnum
{
    public static readonly WindowsServiceTypeEnum KernelDriver =
        new WindowsServiceTypeEnum(EWindowsServiceType.SERVICE_KERNEL_DRIVER);

    public static readonly WindowsServiceTypeEnum FileSystemDriver =
        new WindowsServiceTypeEnum(EWindowsServiceType.SERVICE_FILE_SYSTEM_DRIVER);

    public static readonly WindowsServiceTypeEnum Win32OwnProcess =
        new WindowsServiceTypeEnum(EWindowsServiceType.SERVICE_WIN32_OWN_PROCESS);

    public static readonly WindowsServiceTypeEnum Win32ShareProcess =
        new WindowsServiceTypeEnum(EWindowsServiceType.SERVICE_WIN32_SHARE_PROCESS);

    private enum EWindowsServiceType
    {
        // ReSharper disable InconsistentNaming

        SERVICE_KERNEL_DRIVER,
        SERVICE_FILE_SYSTEM_DRIVER,
        SERVICE_WIN32_OWN_PROCESS,
        SERVICE_WIN32_SHARE_PROCESS

        // ReSharper restore InconsistentNaming
    }

    private WindowsServiceTypeEnum(Enum @enum) : base(@enum)
    {
    }

    public static string TypeName => "windows-service-type-enum";
}