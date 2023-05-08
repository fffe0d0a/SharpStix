using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsRegistryKey() : CyberObservableObject()
{
    private const string TYPE = "windows-registry-key";

    public string? Key { get; init; }
    public List<WindowsRegistryValue>? Values { get; init; }
    public DateTime? ModifiedTime { get; init; }
    public StixIdentifier? CreatorUserRef { get; init; }
    public int? NumberOfSubkeys { get; init; }


    [StixTypeDiscriminator(TYPE)]
    public sealed record WindowsRegistryValue() : CyberObservableObject() //todo move me
    {
        private const string TYPE = "windows-registry-value-type";

        public string? Name { get; init; }
        public string? Data { get; init; }
        public WindowsRegistryDatatypeEnum? DataType { get; init; }

        public override string Type => TYPE;
    }

    public override string Type => TYPE;
}