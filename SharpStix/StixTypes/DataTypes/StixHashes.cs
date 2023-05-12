using System.Text.Json.Serialization;
using FluentValidation;
using SharpStix.Common.Helpers;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Serialisation.Json.Converters.DataTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(StixHashesConverter))]
public class StixHashes : Dictionary<HashingAlgorithm, string>, IStixDataType
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