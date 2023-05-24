using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record UserAccount : CyberObservableObject
{
    private const string TYPE = "user-account";

    public string? UserId { get; init; }
    public string? Credential { get; init; }
    public string? AccountLogin { get; init; }
    public AccountType? AccountType { get; init; }
    public string? DisplayName { get; init; }
    public bool? IsServiceAccount { get; init; }
    public bool? IsPrivileged { get; init; }
    public bool? CanEscalatePrivs { get; init; }
    public bool? IsDisabled { get; init; }
    public DateTime? AccountCreated { get; init; }
    public DateTime? AccountExpires { get; init; }
    public DateTime? CredentialLastChanged { get; init; }
    public DateTime? AccountFirstLogin { get; init; }
    public DateTime? AccountLastLogin { get; init; }


    public override string Type => TYPE;
}