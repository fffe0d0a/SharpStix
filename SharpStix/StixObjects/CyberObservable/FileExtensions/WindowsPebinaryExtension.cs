using SharpStix.Services;
using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.CyberObservable;

[StixTypeDiscriminator(TYPE)]
public sealed record WindowsPebinaryExtension : FileExtension
{
    private const string TYPE = "windows-pebinary-ext";

    public required WindowsPebinaryType PeType { get; init; }
    public string? Imphash { get; init; }
    public StixHex? MachineHex { get; init; }
    public Int54? NumberOfSections { get; init; }
    public DateTime? TimeDateStamp { get; init; }
    public StixHex? PointerToSymbolTableHex { get; init; }
    public Int54? NumberOfSymbols { get; init; }
    public Int54? SizeOfOptionalHeader { get; init; }
    public StixHex? CharacteristicsHex { get; init; }
    public StixHashes? FileHeaderHashes { get; init; }
    public WindowsPeOptionalHeader? OptionalHeader { get; init; }
    public StixList<WindowsPeSection>? Sections { get; init; }

    public override string Type => TYPE;
}