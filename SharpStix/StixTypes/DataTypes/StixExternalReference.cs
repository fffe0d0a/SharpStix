using FluentValidation;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public record StixExternalReference: IStixDataType
{
    private const string TYPE = "external-reference";

    public required string SourceName { get; init; }
    public string? Description { get; init; }
    public string? Url { get; init; }
    public StixHashes? Hashes { get; init; }
    public string? ExternalId { get; init; }

    public string Type => TYPE;
}

internal class StixExternalReferenceValidator : AbstractValidator<StixExternalReference>
{
    public StixExternalReferenceValidator()
    {
        RuleFor(x => x)
            .Must(x => !string.IsNullOrEmpty(x.Description) || !string.IsNullOrEmpty(x.Url) ||
                       !string.IsNullOrEmpty(x.ExternalId))
            .WithSeverity(Severity.Error)
            .WithMessage(
                $"Either {nameof(StixExternalReference.Description)}, {nameof(StixExternalReference.Url)} or {nameof(StixExternalReference.ExternalId)} must have a value.");

        RuleFor(x => x.Hashes)
            .NotNull()
            .When(x => x.Url != null)
            .WithSeverity(Severity.Warning)
            .WithMessage($"{nameof(StixExternalReference.Hashes)} should not be null when {nameof(StixExternalReference.Url)} is not null.");

        RuleFor(x => x.Hashes).SetValidator(new StixHashesValidator()!).When(x => x.Hashes != null); //warn??
    }
}