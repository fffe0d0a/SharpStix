using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record Directory() : CyberObservableObject()
{
    public required string Path { get; init; }
    public string? PathEnc { get; init; }

    [JsonPropertyName("ctime")] public DateTime? CreatedTime { get; init; }

    [JsonPropertyName("mtime")] public DateTime? ModifiedTime { get; init; }

    [JsonPropertyName("atime")] public DateTime? AccessedTime { get; init; }

    public List<StixIdentifier>? ContainsRefs { get; init; }

    public new static string TypeName => "directory";
}