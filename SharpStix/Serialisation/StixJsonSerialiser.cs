using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Serialisation.Json.Converters.Structs;

namespace SharpStix.Serialisation;

public sealed class StixJsonSerialiser : StixSerialiser
{
    public static readonly StixJsonSerialiser Instance = new StixJsonSerialiser();

    public static readonly JsonSerializerOptions? Options = new JsonSerializerOptions()
    {
        PropertyNameCaseInsensitive = true,
        PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        WriteIndented = true,
        MaxDepth = 128,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
        Converters =
        {
            new DateTimeConverter(),
            new CultureInfoConverter()
        },
        UnmappedMemberHandling = JsonUnmappedMemberHandling.Disallow,
    };

    public override void SerialiseToFile(object value, Type type, string filePath)
    {
        using FileStream fs = File.OpenWrite(filePath);
        fs.Write(Serialise(value, type));
    }

    public override byte[] Serialise<T>(T value) => JsonSerializer.SerializeToUtf8Bytes(value, Options);

    public override void SerialiseToFile<T>(T value, string filePath)
    {
        using FileStream fs = File.OpenWrite(filePath);
        fs.Write(JsonSerializer.SerializeToUtf8Bytes(value));
    }

    public override T? Deserialise<T>(string value) where T : class => JsonSerializer.Deserialize<T>(value, Options);

    public override object? Deserialise(string value, Type type) => JsonSerializer.Deserialize(value, type, Options);

    public override T? DeserialiseFromFile<T>(string filePath) where T : class
    {
        using FileStream fs = File.OpenRead(filePath);
        return JsonSerializer.Deserialize<T>(fs, Options);
    }

    public override object? DeserialiseFromFile(Type type, string filePath)
    {
        using FileStream fs = File.OpenRead(filePath);
        return JsonSerializer.Deserialize(fs, type, Options);
    }

    public override byte[] Serialise(object value, Type type) => JsonSerializer.SerializeToUtf8Bytes(value, type, Options);
}