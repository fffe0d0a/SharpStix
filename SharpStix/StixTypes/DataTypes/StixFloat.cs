using FluentValidation;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public readonly record struct StixFloat(double Value) : IStixDataType
{
    private const string TYPE = "float";

    public string Type => TYPE;
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