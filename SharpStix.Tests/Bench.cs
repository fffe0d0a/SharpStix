using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using Xunit.Abstractions;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.Json;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Serialisation.Json.Converters.Structs;
using SharpStix.StixObjects;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.Tests;

public class Bench
{
    private readonly ITestOutputHelper _testOutputHelper;

    public Bench(ITestOutputHelper testOutputHelper)
    {
        _testOutputHelper = testOutputHelper;
    }

    [Fact]
    public void Benchmark()
    {
        _testOutputHelper.WriteLine(BenchmarkRunner.Run<JsonBenchmarks>().ToString());
    }
}

[SimpleJob(iterationCount:500)]
public class JsonBenchmarks
{
    private static readonly JsonSerializerOptions Options = new JsonSerializerOptions()
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

    private static string Json = File.ReadAllText("test.json");

    [Benchmark]
    public Bundle JsonDeserialise()
    {
        return JsonSerializer.Deserialize<Bundle>(Json, Options)!;
    }
}