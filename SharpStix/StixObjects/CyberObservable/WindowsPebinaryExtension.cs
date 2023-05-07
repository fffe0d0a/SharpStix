using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.CyberObservable;

public sealed record WindowsPebinaryExtension() : CyberObservableObject()
{
    public required WindowsPebinaryType PeType { get; init; }
    public string? Imphash { get; init; }
    public byte[]? MachineHex { get; init; }
    public int? NumberOfSections { get; init; }
    public DateTime? TimeDateStamp { get; init; }
    public byte[]? PointerToSymbolTableHex { get; init; }
    public int? NumberOfSymbols { get; init; }
    public int? SizeOfOptionalHeader { get; init; }
    public byte[]? CharacteristicsHex { get; init; }
    public StixHashes? FileHeaderHashes { get; init; }
    public WindowsPeOptionalHeader? OptionalHeader { get; init; }
    public List<WindowsPeSection>? Sections { get; init; }

    public new static string TypeName => "windows-pebinary-ext";
    public sealed record WindowsPeOptionalHeader() : CyberObservableObject() //todo move me
    {
        public byte[]? MagicHex { get; init; }
        public int? MajorLinkerVersion { get; init; }
        public int? MinorLinkerVersion { get; init; }
        public int? SizeOfCode { get; init; }
        public int? SizeOfInitializedData { get; init; }
        public int? SizeOfUninitializedData { get; init; }
        public int? AddressOfEntryPoint { get; init; }
        public int? BaseOfCode { get; init; }
        public int? BaseOfData { get; init; }
        public int? ImageBase { get; init; }
        public int? SectionAlignment { get; init; }
        public int? FileAlignment { get; init; }
        public int? MajorOsVersion { get; init; }
        public int? MinorOsVersion { get; init; }
        public int? MajorImageVersion { get; init; }
        public int? MinorImageVersion { get; init; }
        public int? MajorSubsystemVersion { get; init; }
        public int? MinorSubsystemVersion { get; init; }

        [JsonPropertyName("win32_version_value_hex")]
        public byte[]? Win32VersionValueHex { get; init; }

        public int? SizeOfImage { get; init; }
        public int? SizeOfHeaders { get; init; }
        public byte[]? ChecksumHex { get; init; }
        public byte[]? SubsystemHex { get; init; }
        public int? SizeOfStackReserve { get; init; }
        public int? SizeOfStackCommit { get; init; }
        public int? SizeOfHeapReserve { get; init; }
        public int? SizeOfHeapCommit { get; init; }
        public byte[]? LoaderFlagsHex { get; init; }
        public int? NumberOfRvaAndSizes { get; init; }
        public StixHashes? Hashes { get; init; }

        public new static string TypeName => "windows-pe-optional-header-type";
    }

    public sealed record WindowsPeSection() : CyberObservableObject() //todo move me
    {
        public required string Name { get; init; }
        public int? Size { get; init; }

        [Range(0, 8)] public float? Entropy { get; init; }

        public StixHashes? Hashes { get; init; }

        public new static string TypeName => "windows-pe-section-type";
    }
}