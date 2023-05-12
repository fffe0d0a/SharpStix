using FluentValidation;

namespace SharpStix.StixTypes;

/// <summary>
///     A signed 54-bit integer number.
/// </summary>
/// <param name="Value"></param>
public readonly record struct StixInteger(long Value) : IStixDataType
{
    private const string TYPE = "integer";

    public static explicit operator long(StixInteger value) => value.Value;
}

internal class StixIntegerValidator : AbstractValidator<StixInteger>
{
    public StixIntegerValidator()
    {
        RuleFor(x => x.Value)
            .InclusiveBetween(-9007199254740991, 9007199254740991)
            .WithSeverity(Severity.Error)
            .WithMessage("Stix integer types must be representable as a signed 54-bit value.");
    }
}