using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record Process : CyberObservableObject
{
    private const string TYPE = "process";

    public new Dictionary<string, string>? Extensions { get; init; } //warn not compliant
    public bool? IsHidden { get; init; }
    public int? Pid { get; init; }
    public DateTime? CreatedTime { get; init; }
    public string? Cwd { get; init; }
    public string? CommandLine { get; init; }
    public Dictionary<string, string>? EnvironmentVariables { get; init; }
    public List<StixIdentifier>? OpenedConnectionRefs { get; init; }
    public StixIdentifier? CreatorUserRef { get; init; }
    public StixIdentifier? ImageRef { get; init; }
    public StixIdentifier? ParentRef { get; init; }
    public List<StixIdentifier>? ChildRefs { get; init; }

    public override string Type => TYPE;
}