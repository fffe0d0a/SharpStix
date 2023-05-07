using FluentValidation;
using SharpStix.Common;
using SharpStix.Common.Helpers;

namespace SharpStix.StixTypes.Vocabulary;

public abstract record StixOpenVocab(string Value) : IStixDataType
{
    protected string Value { get; } = Value;

    public override string ToString() => Value;

    public static implicit operator string(StixOpenVocab v) //warn isn't this implicit with a tostring override?
    {
        return v.ToString();
    }

    public static string TypeName => "open-vocab";
}

internal class StixOpenVocabValidator : AbstractValidator<StixOpenVocab>
{
    public StixOpenVocabValidator()
    {
        RuleFor(x => x.ToString())
            .Matches(RegularExpressions.LowercaseHyphenated())
            .WithSeverity(Severity.Warning)
            .WithMessage("Open Vocabulary should be lowercase, hyphenated text.");
    }
}