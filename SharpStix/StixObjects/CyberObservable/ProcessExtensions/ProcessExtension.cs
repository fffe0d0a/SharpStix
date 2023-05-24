namespace SharpStix.StixObjects.CyberObservable;

public abstract record ProcessExtension : IPredefinedExtension
{
    public abstract string Type { get; }
}