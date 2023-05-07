﻿using FluentValidation;
using SharpStix.Common;
using SharpStix.Services;
using RegularExpressions = SharpStix.Common.Helpers.RegularExpressions;

namespace SharpStix.StixTypes;

[GenericTypeNameHelper("dictionary")]
public class StixDictionary<TValue> : Dictionary<string, TValue>, IStixDataType
{
    public static string TypeName => "dictionary";
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