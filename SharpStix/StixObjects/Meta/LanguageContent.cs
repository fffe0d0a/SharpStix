using System.ComponentModel.DataAnnotations;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

[StixTypeDiscriminator(TYPE)]
public sealed record LanguageContent : MetaObject, IVersioned
{
    private const string TYPE = "language-content";

    public StixList<string>? Labels { get; init; }

    public Confidence? Confidence { get; init; }

    public required StixIdentifier ObjectRef { get; init; }
    public DateTime? ObjectModified { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; } //warn not compiant
    //public required Dictionary<Language, Dictionary<string, List<object>>> Contents { get; init; } //warn tf, big warn, object

    public override string Type => TYPE;
    public required DateTime Modified { get; init; }
    public bool? Revoked { get; init; }
}