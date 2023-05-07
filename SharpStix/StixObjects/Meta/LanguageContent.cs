using System.ComponentModel.DataAnnotations;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

public sealed record LanguageContent() : MetaObject(), IVersioned
{
    public List<string>? Labels { get; init; }

    [Range(0, 100)] public int? Confidence { get; init; }

    public required StixIdentifier ObjectRef { get; init; }
    public DateTime? ObjectModified { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; }
    public required Dictionary<Lang, Dictionary<string, List<object>>> Contents { get; init; } //warn tf
    public required DateTime Modified { get; init; }
    public bool? Revoked { get; init; }

    public new static string TypeName => "language-content";
}