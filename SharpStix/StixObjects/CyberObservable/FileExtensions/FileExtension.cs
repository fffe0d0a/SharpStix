namespace SharpStix.StixObjects.CyberObservable;

public abstract record FileExtension: IPredefinedExtension //note that this is not to use the existing extension facility
{
    public abstract string Type { get; }
}