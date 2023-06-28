using System.Text.Json.Serialization;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPeOptionalHeader : CyberObservableObject
{
    private const string TYPE = "win32-pe-optional-header-type";

    public StixHex? MagicHex { get; init; }
    public Int54? MajorLinkerVersion { get; init; }
    public Int54? MinorLinkerVersion { get; init; }
    public Int54? SizeOfCode { get; init; }
    public Int54? SizeOfInitializedData { get; init; }
    public Int54? SizeOfUninitializedData { get; init; }
    public Int54? AddressOfEntryPoint { get; init; }
    public Int54? BaseOfCode { get; init; }
    public Int54? BaseOfData { get; init; }
    public Int54? ImageBase { get; init; }
    public Int54? SectionAlignment { get; init; }
    public Int54? FileAlignment { get; init; }
    public Int54? MajorOsVersion { get; init; }
    public Int54? MinorOsVersion { get; init; }
    public Int54? MajorImageVersion { get; init; }
    public Int54? MinorImageVersion { get; init; }
    public Int54? MajorSubsystemVersion { get; init; }
    public Int54? MinorSubsystemVersion { get; init; }

    [JsonPropertyName("win32_version_value_hex")]
    public StixHex? Win32VersionValueHex { get; init; }

    public Int54? SizeOfImage { get; init; }
    public Int54? SizeOfHeaders { get; init; }
    public StixHex? ChecksumHex { get; init; }
    public StixHex? SubsystemHex { get; init; }
    public Int54? SizeOfStackReserve { get; init; }
    public Int54? SizeOfStackCommit { get; init; }
    public Int54? SizeOfHeapReserve { get; init; }
    public Int54? SizeOfHeapCommit { get; init; }
    public StixHex? LoaderFlagsHex { get; init; }
    public Int54? NumberOfRvaAndSizes { get; init; }
    public StixHashes? Hashes { get; init; }

    [JsonIgnore] public override string Type => TYPE;
}