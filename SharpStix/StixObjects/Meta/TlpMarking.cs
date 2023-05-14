using SharpStix.StixTypes;
using SharpStix.StixTypes.Vocabulary;

namespace SharpStix.StixObjects.Meta;

public sealed record TlpMarking : MarkingDefinition
{
    private static readonly DateTime CommonCreationTime = new DateTime(2017, 01, 20, 00, 00, 00, 000, DateTimeKind.Utc);

#pragma warning disable CS0618
    public static readonly TlpMarking White = new TlpMarking
    {
        SpecVersion = SpecVersion.CurrentVersion,
        Id = new StixIdentifier("marking-definition", "613f2e26-407d-48c7-9eca-b8e91df99dc9"),
        Created = CommonCreationTime,
        Name = "TLP:WHITE",
        Definition = new TlpDefinition { Tlp = "white"}
    };

    public static readonly TlpMarking Green = new TlpMarking
    {
        SpecVersion = SpecVersion.CurrentVersion,
        Id = new StixIdentifier("marking-definition", "34098fce-860f-48ae-8e50-ebd3cc5e41da"),
        Created = CommonCreationTime,
        Name = "TLP:GREEN",
        Definition = new TlpDefinition { Tlp = "green" }
    };

    public static readonly TlpMarking Amber = new TlpMarking
    {
        SpecVersion = SpecVersion.CurrentVersion,
        Id = new StixIdentifier("marking-definition", "f88d31f6-486f-44da-b317-01333bde0b82"),
        Created = CommonCreationTime,
        Name = "TLP:AMBER",
        Definition = new TlpDefinition { Tlp = "amber" }
    };

    public static readonly TlpMarking Red = new TlpMarking
    {
        SpecVersion = SpecVersion.CurrentVersion,
        Id = new StixIdentifier("marking-definition", "5e57c739-391a-4eb3-b6be-7d15ca92d5ed"),
        Created = CommonCreationTime,
        Name = "TLP:RED",
        Definition = new TlpDefinition { Tlp = "red" }
    };

    private TlpMarking()
    {
        DefinitionType = DefinitionType.Tlp;
    }
#pragma warning restore CS0618
}

public sealed record TlpDefinition : ObjectDefinition
{
    public required string Tlp { get; init; }

    public override string ToString() => Tlp;
}