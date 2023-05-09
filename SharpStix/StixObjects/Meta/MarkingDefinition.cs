using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

public interface IMarkingObject
{
}

[StixTypeDiscriminator(TYPE)]
public abstract record MarkingDefinition : MetaObject //warn not implemented correctly
{
    private const string TYPE = "marking-definition";

    public string? Name { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; } //warn object and not stix dict

    //[Obsolete("Deprecated per STIX 2.1.")] public object? DefinitionType { get; init; } //warn

    [Obsolete("Deprecated per STIX 2.1.")] public IMarkingObject? Definition { get; init; }
}

public sealed record StatementMarkingObject : IMarkingObject
{
    public required string Statement { get; init; }
}

public sealed record TlpMarkingObject : IMarkingObject
{
    public required string Tlp { get; init; }
}