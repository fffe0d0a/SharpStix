using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record File : CyberObservableObject, IHasPredefinedExtensions<File, FileExtension> //todo validate, //extensions in files are commonly used
{
    private const string TYPE = "file";

    public StixHashes? Hashes { get; init; }
    public Int54? Size { get; init; }
    public string? Name { get; init; }
    public string? NameEnc { get; init; }
    public StixHex? MagicNumberHex { get; init; }
    public string? MimeType { get; init; }
    public string? PathEnc { get; init; }

    [JsonPropertyName("ctime")] public DateTime? CreatedTime { get; init; }

    [JsonPropertyName("mtime")] public DateTime? ModifiedTime { get; init; }

    [JsonPropertyName("atime")] public DateTime? AccessedTime { get; init; }
    
    public StixIdentifier? ParentDirectoryRef { get; init; }
    public StixList<StixIdentifier>? ContainsRefs { get; init; }
    public StixIdentifier? ContentRef { get; init; }

    public override string Type => TYPE;
}