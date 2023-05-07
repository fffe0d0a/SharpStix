using System.Runtime.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[DataContract(Name = "email-addr")] //todo untested
public sealed record EmailAddress() : CyberObservableObject()
{
    public required string Value { get; init; }
    public string? DisplayName { get; init; }
    public StixIdentifier? BelongsToRef { get; init; }

    public new static string TypeName => "email-addr";
}