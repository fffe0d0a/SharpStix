using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Meta;

[StixTypeDiscriminator(TYPE)]
public record MarkingDefinition : MetaObject //this type is a mess, don't blame me
{
    private const string TYPE = "marking-definition";

    public string? Name { get; init; }

    [Obsolete("Deprecated per STIX 2.1.")]
    public DefinitionType? DefinitionType { get; init; }

    [Obsolete("Deprecated per STIX 2.1.")]
    public ObjectDefinition? Definition { get; init; }

    [JsonExtensionData] public StixExtensions? Extensions { get; init; }

    public override string Type => TYPE;
}


[JsonConverter(typeof(ObjectDefinitionConverter))]
public abstract record ObjectDefinition;

public class MarkingDefinitionValidator : AbstractValidator<MarkingDefinition>
{
#pragma warning disable CS0618
    public MarkingDefinitionValidator()
    {
        RuleFor(x => x.Extensions)
            .NotEmpty()
            .When(x => x.Definition is null || x.DefinitionType is null)
            .WithSeverity(Severity.Error)
            .WithMessage(
                $"When {nameof(MarkingDefinition.Extensions)} is empty, both {nameof(MarkingDefinition.Definition)} and {nameof(MarkingDefinition.DefinitionType)} must be present.");
    }
#pragma warning restore CS0618
}