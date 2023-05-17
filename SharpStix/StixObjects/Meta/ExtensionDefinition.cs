using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.Meta;

[StixTypeDiscriminator(TYPE)]
public sealed record ExtensionDefinition : MetaObject, IVersioned //this is a schema of sorts
{
    private const string TYPE = "extensions-definition";

    public StixList<string>? Labels { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string Schema { get; init; }
    public required string Version { get; init; }
    public required StixList<ExtensionTypeEnum> ExtensionTypes { get; init; }
    public StixList<string>? ExtensionProperties { get; init; }

    public override string Type => TYPE;
    public required DateTime Modified { get; init; }
#pragma warning disable CS8767 //This property is required per STIX 2.1
    public new required StixIdentifier CreatedByRef { get; init; }
#pragma warning restore CS8767
    public bool? Revoked { get; init; }
}