using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public record MitreObjectVersionReference : IStixDataType
{
    private const string TYPE = "object-version-ref";

    public required StixIdentifier ObjectRef { get; init; }
    public required DateTime ObjectModified { get; init; }
}