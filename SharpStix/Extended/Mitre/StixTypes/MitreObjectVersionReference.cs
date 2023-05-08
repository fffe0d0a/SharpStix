using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

[StixTypeDiscriminator(TYPE)]
public record MitreObjectVersionReference : IStixDataType
{
    private const string TYPE = "object-version-ref";

    public required StixIdentifier ObjectRef { get; init; }
    public required StixTimestamp ObjectModified { get; init; }

    public string Type => TYPE;
}