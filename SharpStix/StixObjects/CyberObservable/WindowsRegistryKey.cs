using SharpStix.Services;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsRegistryKey : CyberObservableObject
{
    private const string TYPE = "windows-registry-key";

    public string? Key { get; init; }
    public StixList<WindowsRegistryValue>? Values { get; init; }
    public DateTime? ModifiedTime { get; init; }
    public StixIdentifier? CreatorUserRef { get; init; }
    public StixInteger? NumberOfSubkeys { get; init; }

    public override string Type => TYPE;
}