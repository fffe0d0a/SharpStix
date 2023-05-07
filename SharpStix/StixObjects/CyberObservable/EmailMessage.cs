using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record EmailMessage() : CyberObservableObject()
{
    public required bool IsMultipart { get; init; }
    public DateTime? Date { get; init; }
    public string? ContentType { get; init; }
    public StixIdentifier? FromRef { get; init; }
    public StixIdentifier? SenderRef { get; init; }
    public List<StixIdentifier>? CcRefs { get; init; }
    public List<StixIdentifier>? BccRefs { get; init; }
    public string? MessageId { get; init; }
    public string? Subject { get; init; }
    public List<string>? ReceivedLines { get; init; }
    public Dictionary<string, List<string>>? AdditionalHeaderFields { get; init; }
    public string? Body { get; init; }
    public List<EmailMimeComponent>? BodyMultipart { get; init; }
    public StixIdentifier? RawEmailRef { get; init; }

    public new static string TypeName => "email-message";

    public sealed record EmailMimeComponent() : CyberObservableObject() //todo move me and other components
    {
        public string? Body { get; init; }
        public StixIdentifier? BodyRawRef { get; init; }
        public string? ContentType { get; init; }
        public string? ContentDisposition { get; init; }

        public new static string TypeName => "email-mime-part-type";
    }
}