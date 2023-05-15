using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;
using System.Text.Json.Serialization;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record EmailMimeComponent : CyberObservableObject
{
    private const string TYPE = "email-mime-part-type";

    public string? Body { get; init; }
    public StixIdentifier? BodyRawRef { get; init; }
    public string? ContentType { get; init; }
    public string? ContentDisposition { get; init; }

    [JsonIgnore]
    public override string Type => TYPE;
}