using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Domain;

[StixTypeDiscriminator(TYPE)]
public sealed record Note() : DomainObject()
{
    private const string TYPE = "note";

    /// <summary>
    ///     A brief summary of the note content.
    /// </summary>
    public string? Abstract { get; init; }

    /// <summary>
    ///     The content of the note.
    /// </summary>
    public required string Content { get; init; }

    /// <summary>
    ///     The name of the author(s) of this note (e.g., the analyst(s) that created it).
    /// </summary>
    public List<string>? Authors { get; init; }

    /// <summary>
    ///     The STIX Objects that the note is being applied to.
    /// </summary>
    public List<StixIdentifier>? ObjectRefs { get; init; }

    public override string Type => TYPE;
}