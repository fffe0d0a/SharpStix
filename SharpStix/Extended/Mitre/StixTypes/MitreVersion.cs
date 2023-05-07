using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

public readonly record struct MitreVersion : IStixDataType
{
    public MitreVersion(string version)
    {
        string[] split = version.Split('.');
        MajorVersion = split[0];
        MinorVersion = split[1];
        PatchVersion = split[2];
    }

    public MitreVersion(string majorVersion, string minorVersion, string patchVersion)
    {
        MajorVersion = majorVersion;
        MinorVersion = minorVersion;
        PatchVersion = patchVersion;
    }

    public required string MajorVersion { get; init; }
    public required string MinorVersion { get; init; }
    public required string PatchVersion { get; init; }

    public string Version => $"{MajorVersion}.{MinorVersion}.{PatchVersion}";
    public static string TypeName => "x-mitre-version";
}