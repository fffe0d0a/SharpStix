using SharpStix.StixTypes;

namespace SharpStix.StixObjects.Meta;

public interface IMarkingObject
{
}

public abstract record MarkingDefinition() : MetaObject()
{
    public string? Name { get; init; }
    public Dictionary<StixIdentifier, object>? Extensions { get; init; }

    [Obsolete("Deprecated per STIX 2.1.")] public object? DefinitionType { get; init; } //todo

    [Obsolete("Deprecated per STIX 2.1.")] public IMarkingObject? Definition { get; init; }

    public new static string TypeName => "marking-definition";
}

public sealed record StatementMarkingObject : IMarkingObject
{
    public required string Statement { get; init; }
}

public sealed record TlpMarkingObject : IMarkingObject
{
    public required string Tlp { get; init; }
}