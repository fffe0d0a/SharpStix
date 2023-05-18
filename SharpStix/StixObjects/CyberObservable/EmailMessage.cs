using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record EmailMessage : CyberObservableObject
{
    private const string TYPE = "email-message";

    public required bool IsMultipart { get; init; }
    public DateTime? Date { get; init; }
    public string? ContentType { get; init; }
    public StixIdentifier? FromRef { get; init; }
    public StixIdentifier? SenderRef { get; init; }
    public StixList<StixIdentifier>? ToRefs { get; init; }
    public StixList<StixIdentifier>? CcRefs { get; init; }
    public StixList<StixIdentifier>? BccRefs { get; init; }
    public string? MessageId { get; init; }
    public string? Subject { get; init; }
    public StixList<string>? ReceivedLines { get; init; }
    public StixDictionary<List<string>>? AdditionalHeaderFields { get; init; }
    public string? Body { get; init; }
    public StixList<EmailMimeComponent>? BodyMultipart { get; init; }
    public StixIdentifier? RawEmailRef { get; init; }

    public override string Type => TYPE;
}