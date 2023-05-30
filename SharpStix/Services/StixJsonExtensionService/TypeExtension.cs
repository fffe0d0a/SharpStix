using System.Reflection;

namespace SharpStix.Services;

internal static partial class StixJsonUpgradeService
{
    private readonly struct TypeExtension
    {
        public TypeExtension(Type type, params Property[] properties)
        {
            Type = type;
            Properties = properties;
        }

        public Type Type { get; }
        public Property[] Properties { get; }

        public static TypeExtension FromTypePair(Type parent, Type child)
        {
            IEnumerable<PropertyInfo> propertyInfos = child
                .GetProperties()
                .ExceptBy(parent
                    .GetProperties()
                    .Select(x => x.Name), y => y.Name);

            return new TypeExtension(child, propertyInfos.Select(Property.FromPropertyInfo).ToArray());
        }
    }
}