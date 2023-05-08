using FluentValidation;
using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public readonly record struct StixInteger(long Value) : IStixDataType
{
    private const string TYPE = "integer";

    public string Type => TYPE;
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