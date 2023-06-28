namespace SharpStix.Common;

/// <summary>
///     Indicates that the given <see cref="T" /> can be constructed from a string.
/// </summary>
/// <typeparam name="T">Type of implementer</typeparam>
public interface IFromString<out T> where T : IFromString<T>
{
    public abstract static T FromString(string value);
}