using SharpStix.StixObjects;

namespace SharpStix.Extensions.Mitre;

public record MitreCollection : StixObject
{

    public new static string TypeName => "x-mitre-collection";
}