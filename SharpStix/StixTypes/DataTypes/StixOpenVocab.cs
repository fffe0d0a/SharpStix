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
    protected string Value { get; } = Value;

    public abstract string Type { get; }

    public override string ToString()
    {
        return Value;
    }

    public static implicit operator string(StixOpenVocab v)
    {
        return v.ToString();
    }
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