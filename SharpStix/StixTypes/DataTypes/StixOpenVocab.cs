using System.Diagnostics;
using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.StixObjects;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<StixOpenVocab>))]
[DebuggerDisplay("{Value}")]
public abstract record StixOpenVocab(string Value) : IStixDataType, IHasTypeName
{
    private const string TYPE = "open-vocab";

    protected string Value { get; } = Value;

    public abstract string Type { get; }

    public override string ToString() => Value;

    public static implicit operator string(StixOpenVocab v) => v.ToString();


    public static T FromString<T>(string value) where T : StixOpenVocab
    {
        if (typeof(T) == typeof(StixOpenVocab))
            throw new ArgumentException("Cannot instance an abstract type.", nameof(T));

        return (T)Activator.CreateInstance(typeof(T), value)!;
    }


}

internal class StixOpenVocabValidator : AbstractValidator<StixOpenVocab>
{
    public StixOpenVocabValidator()
    {
        RuleFor(x => x.ToString())
            .Matches(RegularExpressions.LowercaseHyphenated())
            .WithSeverity(Severity.Warning)
            .WithMessage("Open Vocabulary should be lowercase, hyphenated text."); //warn not true no? see hashingalgo
    }
}