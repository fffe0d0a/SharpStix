using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public readonly record struct MitreAttackSpecVersion : IStixDataType
{
    public MitreAttackSpecVersion(string version)
    {
        Version = version;
    }

    public required string Version { get; init; }

    public static string TypeName => "x-mitre-attack-spec-version";
}