using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsServiceExtension : ProcessExtension
{
    private const string TYPE = "window-service-ext";

    public string? ServiceName { get; init; }
    public StixList<string>? Descriptions { get; init; }
    public string? DisplayName { get; init; }
    public string? GroupName { get; init; }
    public WindowsServiceStartTypeEnum? StartType { get; init; }
    public StixList<StixIdentifier>? ServiceDllRefs { get; init; }
    public WindowsServiceTypeEnum? ServiceType { get; init; }
    public WindowsServiceStatusEnum? ServiceStatus { get; init; }

    public override string Type => TYPE;
}