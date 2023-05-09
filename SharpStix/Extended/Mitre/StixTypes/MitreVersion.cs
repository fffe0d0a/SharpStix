using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.Extended.Mitre.StixTypes;

[JsonConverter(typeof(MitreVersionConverter))]
public readonly record struct MitreVersion : IStixDataType
{
    private const string TYPE = "x-mitre-version";

    public required int MajorVersion { get; init; }
    public required int MinorVersion { get; init; }
    public required int PatchVersion { get; init; }

    public override string ToString()
    {
        return $"{MajorVersion}.{MinorVersion}.{PatchVersion}";
    }

    public static MitreVersion FromString(string value)
    {
        string[] split = value.Split('.');
        return new MitreVersion
        {
            MajorVersion = Convert.ToInt32(split.ElementAtOrDefault(0)),
            MinorVersion = Convert.ToInt32(split.ElementAtOrDefault(1)),
            PatchVersion = Convert.ToInt32(split.ElementAtOrDefault(2))
        };
    }
}

public class MitreVersionConverter : JsonConverter<MitreVersion>
{
    public override MitreVersion Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return MitreVersion.FromString(reader.GetString() ?? throw new InvalidOperationException());
    }

    public override void Write(Utf8JsonWriter writer, MitreVersion value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(value.ToString());
    }
}