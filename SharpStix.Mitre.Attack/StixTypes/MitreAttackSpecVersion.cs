using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Mitre.Attack.StixTypes;

[JsonConverter(typeof(MitreAttackSpecVersionConverter))]
public readonly record struct MitreAttackSpecVersion : IStixDataType
{
    private const string TYPE = "x-mitre-attack-spec-version";

    public required string Version { get; init; }

    public override string ToString() => Version;
}

public class MitreAttackSpecVersionConverter : JsonConverter<MitreAttackSpecVersion>
{
    public override MitreAttackSpecVersion Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options) =>
        new MitreAttackSpecVersion { Version = reader.GetString() ?? throw new InvalidOperationException() };

    public override void Write(Utf8JsonWriter writer, MitreAttackSpecVersion value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}