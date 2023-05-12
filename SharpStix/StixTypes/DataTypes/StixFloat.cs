using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

/// <summary>
///     A double precision floating point number that must not be infinity or NaN to be considered valid.
/// </summary>
/// <param name="Value"></param>
[JsonConverter(typeof(StixFloatConverter))]
public readonly record struct StixFloat(double Value) : IStixDataType
{
    private const string TYPE = "float";

    public static implicit operator double(StixFloat value) => value.Value;
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