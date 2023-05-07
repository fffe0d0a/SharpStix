using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public record MitreObjectVersionReference : IStixDataType
{
    public required StixIdentifier ObjectRef { get; init; }
    public required StixTimestamp ObjectModified { get; init; }

    public static string TypeName => "object-version-ref";
}