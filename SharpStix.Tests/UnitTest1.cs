using System.Text.Json;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;
using SharpStix.StixObjects;

namespace SharpStix.Tests;

//'ate python, 'ate java, luv me C#, simple as
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Type? t = StixTypeDiscriminationService.GetTypeFromString("bundle");

        string q = File.ReadAllText("enterprise-attack.json");



        JsonSerializerOptions options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };
        options.Converters.Add(new StixIdentifierConverter());
        options.Converters.Add(new StixObjectConverter());

        JsonSerializer.Deserialize<Bundle>(q, options);

        StixContext context = new StixContext();
        context.AddObjectsFromJson(File.ReadAllText("enterprise-attack.json"));
    }
}
