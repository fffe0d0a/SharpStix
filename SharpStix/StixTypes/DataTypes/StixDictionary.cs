using FluentValidation;
using SharpStix.Common.Helpers;

namespace SharpStix.StixTypes;

public class StixDictionary<TValue> : Dictionary<string, TValue>, IStixDataType
{
    private const string TYPE = "dictionary";
}

internal class StixDictionaryValidator<TValue> : AbstractValidator<StixDictionary<TValue>>
{
    public StixDictionaryValidator()
    {
        RuleFor(x => x).NotEmpty().WithSeverity(Severity.Error);
        RuleForEach(x => x.Keys).Matches(RegularExpressions.ValidDictionaryKey()).WithSeverity(Severity.Error);
        RuleForEach(x => x.Keys).Must(x => x.All(c => !char.IsUpper(c))).WithSeverity(Severity.Warning)
            .WithMessage($"{nameof(StixDictionary<TValue>)} keys should be lowercase.");
    }
}