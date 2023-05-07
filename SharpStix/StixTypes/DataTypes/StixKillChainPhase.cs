using FluentValidation;
using SharpStix.Common.Helpers;

namespace SharpStix.StixTypes;

public record StixKillChainPhase : IStixDataType
{
    public required string KillChainName { get; init; }
    public required string PhaseName { get; init; }

    public static string TypeName => "kill-chain-phase";
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