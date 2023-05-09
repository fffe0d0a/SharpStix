using FluentValidation;

namespace SharpStix.StixTypes;

public class StixList<T> : List<T>, IStixDataType
{
    private const string TYPE = "list";
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