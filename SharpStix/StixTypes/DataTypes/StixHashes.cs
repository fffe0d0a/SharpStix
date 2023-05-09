using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixTypes;

public class StixHashes : Dictionary<HashingAlgorithm, StixString>, IStixDataType
{
    private const string TYPE = "hashes";
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