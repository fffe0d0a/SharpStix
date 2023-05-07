using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record WindowsServiceExtension() : CyberObservableObject()
{
    public string? ServiceName { get; init; }
    public List<string>? Descriptions { get; init; }
    public string? DisplayName { get; init; }
    public string? GroupName { get; init; }
    public WindowsServiceStartTypeEnum? StartType { get; init; }
    public List<StixIdentifier>? ServiceDllRefs { get; init; }
    public WindowsServiceTypeEnum? ServiceType { get; init; }
    public WindowsServiceStatusEnum? ServiceStatus { get; init; }

    public new static string TypeName => "windows-service-ext";
}