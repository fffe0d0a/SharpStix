using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;
using SharpStix.StixTypes;
using System.Text.Json.Serialization;

namespace SharpStix.StixObjects;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPeOptionalHeader : CyberObservableObject //todo move me
{
    private const string TYPE = "win32-pe-optional-header-type";

    public StixHex? MagicHex { get; init; }
    public StixInteger? MajorLinkerVersion { get; init; }
    public StixInteger? MinorLinkerVersion { get; init; }
    public StixInteger? SizeOfCode { get; init; }
    public StixInteger? SizeOfInitializedData { get; init; }
    public StixInteger? SizeOfUninitializedData { get; init; }
    public StixInteger? AddressOfEntryPoint { get; init; }
    public StixInteger? BaseOfCode { get; init; }
    public StixInteger? BaseOfData { get; init; }
    public StixInteger? ImageBase { get; init; }
    public StixInteger? SectionAlignment { get; init; }
    public StixInteger? FileAlignment { get; init; }
    public StixInteger? MajorOsVersion { get; init; }
    public StixInteger? MinorOsVersion { get; init; }
    public StixInteger? MajorImageVersion { get; init; }
    public StixInteger? MinorImageVersion { get; init; }
    public StixInteger? MajorSubsystemVersion { get; init; }
    public StixInteger? MinorSubsystemVersion { get; init; }

    [JsonPropertyName("win32_version_value_hex")]
    public StixHex? Win32VersionValueHex { get; init; }

    public StixInteger? SizeOfImage { get; init; }
    public StixInteger? SizeOfHeaders { get; init; }
    public StixHex? ChecksumHex { get; init; }
    public StixHex? SubsystemHex { get; init; }
    public StixInteger? SizeOfStackReserve { get; init; }
    public StixInteger? SizeOfStackCommit { get; init; }
    public StixInteger? SizeOfHeapReserve { get; init; }
    public StixInteger? SizeOfHeapCommit { get; init; }
    public StixHex? LoaderFlagsHex { get; init; }
    public StixInteger? NumberOfRvaAndSizes { get; init; }
    public StixHashes? Hashes { get; init; }

    public override string Type => TYPE;
}