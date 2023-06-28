using System.Diagnostics;
using System.Text.Json;
using System.Text.Json.Serialization;
using SharpStix.Common.Extensions;
using SharpStix.StixObjects.CyberObservable;

namespace SharpStix.StixTypes;

[Obsolete("Deprecated as of STIX 2.1.")]
[JsonConverter(typeof(ObservableContainerConverter))]
public class
    StixObservableContainer : Dictionary<StixIdentifier, CyberObservableObject>,
        IStixDataType //warn likely not implemented properly
{
    private const string TYPE = "observable-container";
}

[Obsolete("Deprecated as of STIX 2.1.")]
public class ObservableContainerConverter : JsonConverter<StixObservableContainer>
{
    private static CyberObservableObject? ResolveElement(in JsonProperty element, in JsonSerializerOptions options)
    {
        Type? type = element.Value.ResolveTypeFromDiscriminator();
        if (type != null)
            return (CyberObservableObject?)element.Value.Deserialize(type, options);

        Debug.WriteLine(
            $"Skipped deserialisation of unknown {nameof(StixObservableContainer)}. {element.Value.GetRawText()}");
        return null;
    }

    public override StixObservableContainer? Read(ref Utf8JsonReader reader, Type typeToConvert,
        JsonSerializerOptions options)
    {
        using JsonDocument document = JsonDocument.ParseValue(ref reader);
        StixObservableContainer container = new StixObservableContainer();

        foreach (JsonProperty element in document.RootElement.EnumerateObject())
        {
            StixIdentifier identifier = new StixIdentifier(element.Name); //can throw
            CyberObservableObject? instance = ResolveElement(element, options);

            if (instance != null)
                container.Add(identifier, instance);
        }

        return container.Count != 0
            ? container
            : null;
    }

    public override void Write(Utf8JsonWriter writer, StixObservableContainer value, JsonSerializerOptions options)
    {
        throw new NotImplementedException();
    }
}