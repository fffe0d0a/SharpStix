using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

[JsonConverter(typeof(MitreAttackSpecVersionConverter))]
public readonly record struct MitreAttackSpecVersion : IStixDataType
{
    public required string Version { get; init; }

    public static string TypeName => "x-mitre-attack-spec-version";

    public override string ToString() => Version;
}

public class MitreAttackSpecVersionConverter : JsonConverter<MitreAttackSpecVersion>
{
    public override MitreAttackSpecVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options) => new MitreAttackSpecVersion {Version = reader.GetString() ?? throw new InvalidOperationException()};

    public override void Write(Utf8JsonWriter writer, MitreAttackSpecVersion value, JsonSerializerOptions options) => writer.WriteStringValue(value.ToString());
}