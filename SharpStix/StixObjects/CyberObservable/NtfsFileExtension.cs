using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record NtfsFileExtension : CyberObservableObject
{
    private const string TYPE = "ntfs-ext";

    public string? Sid { get; init; }
    public List<AlternateDataStream>? AlternateDataStreams { get; init; }

    public override string Type => TYPE;


    [StixTypeDiscriminator(TYPE)]
    public sealed record AlternateDataStream : CyberObservableObject //todo move me
    {
        private const string TYPE = "alternate-data-stream-type";

        public required string Name { get; init; }
        public StixHashes? Hashes { get; init; }
        public int? Size { get; init; }

        public override string Type => TYPE;
    }
}