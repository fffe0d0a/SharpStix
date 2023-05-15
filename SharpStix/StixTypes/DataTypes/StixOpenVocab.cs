using System.Diagnostics;
using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes.Vocabulary;

//[JsonConverter(typeof(StixOpenVocabConverter<StixOpenVocab>))]
[DebuggerDisplay("{Value}")]
public abstract record StixOpenVocab : IStixDataType, IHasTypeName
{
    protected StixOpenVocab(string value)
    {
        Value = value;
    }

    private const string TYPE = "open-vocab";

    protected string Value { get; }

    public abstract string Type { get; }

    public override string ToString() => Value;

    public static implicit operator string(StixOpenVocab v) => v.Value;
}

internal class StixOpenVocabValidator : AbstractValidator<StixOpenVocab>
{
    public StixOpenVocabValidator()
    {
        RuleFor(x => x.ToString())
            .Matches(RegularExpressions.LowercaseHyphenated())
            .WithSeverity(Severity.Warning)
            .WithMessage("Open Vocabulary should be lowercase, hyphenated text."); //warn Values that are not from the suggested vocabulary SHOULD be all lowercase and SHOULD use hyphens instead of spaces or underscores as word separators.
    }
}