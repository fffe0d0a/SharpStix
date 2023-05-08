using System.ComponentModel.DataAnnotations;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

[StixTypeDiscriminator(TYPE)]
public sealed record LanguageContent() : MetaObject(), IVersioned
{
    private const string TYPE = "language-content";

    public List<string>? Labels { get; init; }

    [Range(0, 100)] public int? Confidence { get; init; }

    public required StixIdentifier ObjectRef { get; init; }
    public DateTime? ObjectModified { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; }
    public required Dictionary<Lang, Dictionary<string, List<object>>> Contents { get; init; } //warn tf
    public required DateTime Modified { get; init; }
    public bool? Revoked { get; init; }

    public override string Type => TYPE;
}