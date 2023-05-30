using SharpStix.Services;
using SharpStix.StixObjects.Domain;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record MitreMatrix : DomainObject
{
    private const string TYPE = "x-mitre-matrix";

    public required StixList<string> TacticRefs { get; init; }

    public override string Type => TYPE;
}