using FluentValidation;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public class StixList<T> : List<T>, IStixDataType
{
    private const string TYPE = "list";

    public string Type => TYPE;
}

internal class StixListValidator<T> : AbstractValidator<StixList<T>>
{
    public StixListValidator()
    {
        RuleFor(x => x)
            .NotEmpty()
            .WithSeverity(Severity.Error)
            .WithMessage($"{nameof(StixList<T>)}s cannot be empty.");
    }
}