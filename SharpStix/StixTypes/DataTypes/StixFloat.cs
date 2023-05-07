using FluentValidation;

namespace SharpStix.StixTypes;

public readonly record struct StixFloat(double Value) : IStixDataType
{
    public static string TypeName => "float";
}

internal class StixFloatValidator : AbstractValidator<StixFloat>
{
    public StixFloatValidator()
    {
        RuleFor(x => x.Value)
            .NotEqual(double.PositiveInfinity)
            .NotEqual(double.NegativeInfinity)
            .NotEqual(double.NaN)
            .WithSeverity(Severity.Error);
    }
}