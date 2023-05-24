using SharpStix.Serialisation;

namespace SharpStix.Tests;

//'ate python, 'ate java, luv me C#, simple as
public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        StixContext context = new StixContext();
        context.AddFromBundleFile(StixJsonSerialiser.Instance, "test.json");
        context.AddFromBundleFile(StixJsonSerialiser.Instance, "enterprise-attack.json");
    }
}