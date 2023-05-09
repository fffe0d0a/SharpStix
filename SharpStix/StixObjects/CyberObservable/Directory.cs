using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Directory : CyberObservableObject
{
    private const string TYPE = "directory";

    public required string Path { get; init; }
    public string? PathEnc { get; init; }

    [JsonPropertyName("ctime")] public DateTime? CreatedTime { get; init; }

    [JsonPropertyName("mtime")] public DateTime? ModifiedTime { get; init; }

    [JsonPropertyName("atime")] public DateTime? AccessedTime { get; init; }

    public StixList<StixIdentifier>? ContainsRefs { get; init; }

    public override string Type => TYPE;
}