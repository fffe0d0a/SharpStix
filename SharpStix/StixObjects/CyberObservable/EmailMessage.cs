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
    public List<StixIdentifier>? CcRefs { get; init; }
    public List<StixIdentifier>? BccRefs { get; init; }
    public string? MessageId { get; init; }
    public string? Subject { get; init; }
    public List<string>? ReceivedLines { get; init; }
    public Dictionary<string, List<string>>? AdditionalHeaderFields { get; init; }
    public string? Body { get; init; }
    public List<EmailMimeComponent>? BodyMultipart { get; init; }
    public StixIdentifier? RawEmailRef { get; init; }

    public override string Type => TYPE;

    [StixTypeDiscriminator(TYPE)]
    public sealed record EmailMimeComponent : CyberObservableObject //todo move me and other components
    {
        private const string TYPE = "email-mime-part-type";

        public string? Body { get; init; }
        public StixIdentifier? BodyRawRef { get; init; }
        public string? ContentType { get; init; }
        public string? ContentDisposition { get; init; }

        public override string Type => TYPE;
    }
}