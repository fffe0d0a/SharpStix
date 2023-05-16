using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record NtfsFileExtension : FileExtension
{
    private const string TYPE = "ntfs-ext";

    public string? Sid { get; init; }
    public StixList<AlternateDataStream>? AlternateDataStreams { get; init; }

    public override string Type => TYPE;
}