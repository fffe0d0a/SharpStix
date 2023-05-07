using SharpStix.StixTypes;
using SharpStix.StixTypes.Enums;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record WindowsRegistryKey() : CyberObservableObject()
{
    public string? Key { get; init; }
    public List<WindowsRegistryValue>? Values { get; init; }
    public DateTime? ModifiedTime { get; init; }
    public StixIdentifier? CreatorUserRef { get; init; }
    public int? NumberOfSubkeys { get; init; }

    public new static string TypeName => "windows-registry-key";

    public sealed record WindowsRegistryValue() : CyberObservableObject() //todo move me
    {
        public string? Name { get; init; }
        public string? Data { get; init; }
        public WindowsRegistryDatatypeEnum? DataType { get; init; }

        public new static string TypeName => "windows-registry-value-type";
    }
}