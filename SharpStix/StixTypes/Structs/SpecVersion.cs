using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;

namespace SharpStix.StixTypes;

[JsonConverter(typeof(SpecVersionConverter))]
public readonly record struct SpecVersion
{
    private const string CURRENT_VERSION_NUMBER = "2.1";
    public static readonly SpecVersion CurrentVersion = new SpecVersion(CURRENT_VERSION_NUMBER);

    public SpecVersion(string version)
    {
        Version = version;
    }

    public string Version { get; }

    public override string ToString() => Version;

    public static SpecVersion GetVersion(string version)
    {
        if (version == CURRENT_VERSION_NUMBER)
            return CurrentVersion;
        return new SpecVersion(version);
    }
}