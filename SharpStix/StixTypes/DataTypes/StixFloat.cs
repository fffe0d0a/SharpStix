using FluentValidation;

namespace SharpStix.StixTypes;

/// <summary>
///     A double precision floating point number that must not be infinity or NaN to be considered valid.
/// </summary>
/// <param name="Value"></param>
public readonly record struct StixFloat(double Value) : IStixDataType
{
    private const string TYPE = "float";
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