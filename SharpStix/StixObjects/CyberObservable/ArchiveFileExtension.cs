using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record ArchiveFileExtension : CyberObservableObject
{
    public required List<StixIdentifier> ContainsRefs { get; init; }
    public string? Comment { get; init; }

    public new static string TypeName => "archive-ext";
}