using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record File() : CyberObservableObject()
{
    public new Dictionary<string, string>? Extensions { get; init; } //warn not compliant
    public StixHashes? Hashes { get; init; }
    public int? Size { get; init; }
    public string? Name { get; init; }
    public string? NameEnc { get; init; }
    public byte[]? MagicNumberHex { get; init; }
    public string? MimeType { get; init; }
    public string? PathEnc { get; init; }

    [JsonPropertyName("ctime")] public DateTime? CreatedTime { get; init; }

    [JsonPropertyName("mtime")] public DateTime? ModifiedTime { get; init; }

    [JsonPropertyName("atime")] public StixIdentifier? ParentDirectoryRef { get; init; }

    public List<StixIdentifier>? ContainsRefs { get; init; }
    public StixIdentifier? ContentRef { get; init; }

    public new static string TypeName => "file";
}