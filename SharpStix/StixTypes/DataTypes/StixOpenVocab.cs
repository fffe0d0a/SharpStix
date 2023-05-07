using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<StixOpenVocab>))]
public abstract record StixOpenVocab(string Value) : IStixDataType
{
    protected string Value { get; } = Value;

    public override string ToString() => Value;

    public static implicit operator string(StixOpenVocab v) => v.ToString();

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