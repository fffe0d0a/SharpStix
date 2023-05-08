using System.Runtime.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[DataContract(Name = "email-addr")] //todo untested
[StixTypeDiscriminator(TYPE)]
public sealed record EmailAddress() : CyberObservableObject()
{
    private const string TYPE = "email-addr";

    public required string Value { get; init; }
    public string? DisplayName { get; init; }
    public StixIdentifier? BelongsToRef { get; init; }

    public override string Type => TYPE;
}