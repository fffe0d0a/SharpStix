using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public record MitreObjectVersionReference : IStixDataType
{
    private const string TYPE = "object-version-ref";

    public required StixIdentifier ObjectRef { get; init; }
    public required DateTime ObjectModified { get; init; } //MUST be an exact match for the modified time of the STIX object being referenced.
}