using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

/// <summary>
///     A signed 54-bit integer.
/// </summary>
[JsonConverter(typeof(Int54Converter))]
public readonly record struct Int54 : IStixDataType
{
    public Int54(long value)
    {
        if (value is < -9007199254740991 or > 9007199254740991)
            throw new ArgumentOutOfRangeException(nameof(value));

        Value = value;
    }

    public long Value { get; }

    private const string TYPE = "integer";

    public static implicit operator long(Int54 value) => value.Value;
    public static explicit operator Int54(long value) => new Int54(value);
}

//internal class StixIntegerValidator : AbstractValidator<Int54>
//{
//    public StixIntegerValidator()
//    {
//        RuleFor(x => x.Value)
//            .InclusiveBetween(-9007199254740991, 9007199254740991)
//            .WithSeverity(Severity.Error)
//            .WithMessage("Stix integer types must be representable as a signed 54-bit value.");
//    }
//}