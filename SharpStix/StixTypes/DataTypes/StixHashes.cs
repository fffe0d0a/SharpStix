using FluentValidation;
using SharpStix.Common;
using SharpStix.StixTypes.Vocabulary;
using System.Linq;
using RegularExpressions = SharpStix.Common.Helpers.RegularExpressions;

namespace SharpStix.StixTypes;


public class StixHashes : Dictionary<HashingAlgorithm, StixString>, IStixDataType
{
    public static string TypeName => "hashes";
}

internal class StixHashesValidator : AbstractValidator<StixHashes>
{
    public StixHashesValidator()
    {
        RuleFor(x => x).NotEmpty().WithSeverity(Severity.Error);
        RuleForEach(x => x.Keys.Select(y => y.ToString())).Matches(RegularExpressions.ValidHashesKey()).WithSeverity(Severity.Error);
    }
}