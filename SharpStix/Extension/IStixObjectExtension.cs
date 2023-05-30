using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using SharpStix.StixObjects;

namespace SharpStix.Extension;

public interface IStixObjectExtension //warn smelly but functional. This helps identify the name of the methods defined in IStixObjectExtension<T, T2> from a non-generic context.
{
    [DoesNotReturn]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static bool CanExtend(StixObject instance) => throw new Exception();
    [DoesNotReturn]
    [EditorBrowsable(EditorBrowsableState.Never)]
    internal static bool TryExtend(StixObject instance, [NotNullWhen(true)] out StixObject? extendedInstance) => throw new Exception();
}

public interface IStixObjectExtension<in T, T2> : IStixObjectExtension where T : StixObject where T2 : T, IStixObjectExtension<T, T2>
{
    /// <summary>
    /// Determines if the provided <typeparamref name="T"></typeparamref> can be converted to a valid <typeparamref name="T2"></typeparamref>.
    /// </summary>
    /// <param name="instance"></param>
    /// <returns>True if the conversion is possible, otherwise false.</returns>
    public abstract static bool CanExtend(T instance);

    //static bool IStixObjectExtension.CanExtend(StixObject instance) => T2.CanExtend((T) instance);

    public abstract static bool TryExtend(T instance, [NotNullWhen(true)] out T2? extendedInstance);

    //static bool IStixObjectExtension.TryExtend(StixObject instance, [NotNullWhen(true)] out StixObject? extendedInstance)
    //{
    //    bool result = T2.TryExtend((T)instance, out T2? genericExtendedInstance);
    //    extendedInstance = genericExtendedInstance;
    //    return result;
    //}
}