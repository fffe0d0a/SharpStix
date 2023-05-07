using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record NtfsFileExtension() : CyberObservableObject()
{
    public string? Sid { get; init; }
    public List<AlternateDataStream>? AlternateDataStreams { get; init; }

    public new static string TypeName => "ntfs-ext";

    public sealed record AlternateDataStream() : CyberObservableObject() //todo move me
    {
        public required string Name { get; init; }
        public StixHashes? Hashes { get; init; }
        public int? Size { get; init; }

        public new static string TypeName => "alternate-data-stream-type";
    }
}