using FluentValidation;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[GenericTypeNameHelper("list")]
public class StixList<T> : List<T>, IStixDataType
{
    public static string TypeName => "list";
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