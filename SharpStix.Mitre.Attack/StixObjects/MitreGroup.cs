using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreGroup : IntrusionSet; //exactly the same

public static class MitreGroupExtensions
{
    public static MitreGroup AsMitreGroup(this IntrusionSet intrusionSet) => (MitreGroup)intrusionSet;
}