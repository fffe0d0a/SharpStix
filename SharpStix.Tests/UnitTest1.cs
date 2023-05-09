using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;
using System.Text.Unicode;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Serialisation.Json.Converters.DataTypes;
using SharpStix.Services;
using SharpStix.StixObjects;
using SharpStix.StixObjects.Domain;
using SharpStix.StixTypes;

namespace SharpStix.Tests;

//'ate python, 'ate java, luv me C#, simple as
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Type? t = StixTypeDiscriminationService.GetTypeFromDiscriminator("bundle");

        string q = File.ReadAllText("enterprise-attack.json");

        JsonSerializerOptions options = new JsonSerializerOptions()
        {
            PropertyNameCaseInsensitive = true, 
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
            WriteIndented = true,
            MaxDepth = 128,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping,
            Converters = { new DateTimeConverter() }
        };

        Bundle quack = JsonSerializer.Deserialize<Bundle>(q, options);

        var doc = JsonSerializer.SerializeToUtf8Bytes(quack, options);
        File.WriteAllBytes("test.json", doc);


        return;

        StixContext context = new StixContext();
        context.AddObjectsFromJson(File.ReadAllText("enterprise-attack.json"));
    }
}
