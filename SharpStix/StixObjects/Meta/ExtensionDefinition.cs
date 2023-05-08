using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.Meta;

[StixTypeDiscriminator(TYPE)]
public sealed record ExtensionDefinition() : MetaObject(), IVersioned
{
    private const string TYPE = "extensions-definition";

    public List<string>? Labels { get; init; }
    public required string Name { get; init; }
    public string? Description { get; init; }
    public required string Schema { get; init; }
    public required string Version { get; init; }
    public required List<ExtensionTypeEnum> ExtensionTypes { get; init; }
    public List<string>? ExtensionProperties { get; init; }
    public required DateTime Modified { get; init; }
#pragma warning disable CS8767 //This property is required per STIX 2.1
    public new required StixIdentifier CreatedByRef { get; init; }
#pragma warning restore CS8767
    public bool? Revoked { get; init; }

    public override string Type => TYPE;
}