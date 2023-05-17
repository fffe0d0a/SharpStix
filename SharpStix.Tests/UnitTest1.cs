using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Serialisation;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Serialisation.Json.Converters.Structs;
using SharpStix.Services;
using SharpStix.StixObjects;
using SharpStix.StixObjects.CyberObservable;
using File = System.IO.File;

namespace SharpStix.Tests;

//'ate python, 'ate java, luv me C#, simple as
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        StixContext context = new StixContext();
        context.AddFromBundleFile(StixJsonSerialiser.Instance, "test.json");





        Type? t = StixTypeDiscriminationService.GetTypeFromDiscriminator("bundle");

        string q = File.ReadAllText("test.json");

        JsonSerializerOptions options = new JsonSerializerOptions()
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

        Bundle quack = JsonSerializer.Deserialize<Bundle>(q, options);

        foreach (StixObject o in quack.Objects.Where(x => x is StixObjects.CyberObservable.File))
        {
            StixObjects.CyberObservable.File file = (StixObjects.CyberObservable.File)o;
            if (file.Extensions != null)
            {
                var qq = ((IHasPredefinedExtensions<StixObjects.CyberObservable.File, FileExtension>)file)
                    .GetPredefinedExtensions();
            }
        }

        foreach (StixObject o in quack.Objects.Where(x => x is NetworkTraffic))
        {
            NetworkTraffic file = (NetworkTraffic)o;

        }

        var doc = JsonSerializer.SerializeToUtf8Bytes(quack, options);
        File.WriteAllBytes("testx.json", doc);


        return;

    }
}