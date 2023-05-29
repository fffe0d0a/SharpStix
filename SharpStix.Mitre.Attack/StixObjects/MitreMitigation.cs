using SharpStix.StixObjects.Domain;

namespace SharpStix.Mitre.Attack.StixObjects;

public sealed record MitreMitigation : CourseOfAction; //exactly the same

public static class MitreMitigationExtensions
{
    public static MitreMitigation AsMitreMitigation(this CourseOfAction action) => (MitreMitigation)action;
}