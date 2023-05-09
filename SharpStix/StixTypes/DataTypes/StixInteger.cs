﻿using FluentValidation;

namespace SharpStix.StixTypes;

public readonly record struct StixInteger(long Value) : IStixDataType
{
    private const string TYPE = "integer";
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