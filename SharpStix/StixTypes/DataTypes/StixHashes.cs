using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.Services;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixTypes;

[StixTypeDiscriminator(TYPE)]
public class StixHashes : Dictionary<HashingAlgorithm, StixString>, IStixDataType
{
    private const string TYPE = "hashes";

    public string Type => TYPE;
}

internal class StixHashesValidator : AbstractValidator<StixHashes>
{
    public StixHashesValidator()
    {
        RuleFor(x => x).NotEmpty().WithSeverity(Severity.Error);
        RuleForEach(x => x.Keys.Select(y => y.ToString())).Matches(RegularExpressions.ValidHashesKey())
            .WithSeverity(Severity.Error);
    }
}