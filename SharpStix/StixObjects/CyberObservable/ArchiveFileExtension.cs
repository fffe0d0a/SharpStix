using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record ArchiveFileExtension : CyberObservableObject
{
    private const string TYPE = "archive-ext";

    public required List<StixIdentifier> ContainsRefs { get; init; }
    public string? Comment { get; init; }

    public override string Type => TYPE;
}