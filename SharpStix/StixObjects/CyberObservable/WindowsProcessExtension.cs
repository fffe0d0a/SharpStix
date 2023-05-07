using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record WindowsProcessExtension() : CyberObservableObject()
{
    public bool? AslrEnabled { get; init; }
    public bool? DepEnabled { get; init; }
    public string? Priority { get; init; }
    public string? OwnerSid { get; init; }
    public string? WindowTitle { get; init; }
    public Dictionary<string, string>? StartupInfo { get; init; }
    public WindowsIntegrityLevelEnum? IntegrityLevel { get; init; }

    public new static string TypeName => "windows-process-ext";
}