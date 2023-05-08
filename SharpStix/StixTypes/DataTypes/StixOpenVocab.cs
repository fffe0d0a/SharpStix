using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<StixOpenVocab>))]
[StixTypeDiscriminator(TYPE)]
public abstract record StixOpenVocab(string Value) : IStixDataType
{
    private const string TYPE = "open-vocab";

    public abstract string Type { get; }
    protected string Value { get; } = Value;

    public override string ToString() => Value;

    public static implicit operator string(StixOpenVocab v) => v.ToString();
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