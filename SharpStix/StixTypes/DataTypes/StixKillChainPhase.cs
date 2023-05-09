using FluentValidation;
using SharpStix.Common.Helpers;

namespace SharpStix.StixTypes;

public record StixKillChainPhase : IStixDataType
{
    private const string TYPE = "kill-chain-phase";

    public required string KillChainName { get; init; }
    public required string PhaseName { get; init; }
}

internal class StixKillChainPhaseValidator : AbstractValidator<StixKillChainPhase>
{
    public StixKillChainPhaseValidator()
    {
        RuleFor(x => x.KillChainName)
            .Matches(RegularExpressions.LowercaseHyphenated())
            .WithSeverity(Severity.Warning);

        RuleFor(x => x.PhaseName)
            .Matches(RegularExpressions.LowercaseHyphenated())
            .WithSeverity(Severity.Warning);
    }
}