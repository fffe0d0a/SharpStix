using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization;

namespace SharpStix.Services;

internal static partial class StixJsonUpgradeService
{
    private readonly struct Property
    {
        public Property(string name, bool isRequired)
        {
            Name = name;
            IsRequired = isRequired;
        }

        public string Name { get; }
        public bool IsRequired { get; }

        public static Property FromPropertyInfo(MemberInfo propertyInfo)
        {
            bool isRequired = propertyInfo.GetCustomAttribute<RequiredMemberAttribute>() != null;

            JsonPropertyNameAttribute? propertyNameAttribute =
                propertyInfo.GetCustomAttribute<JsonPropertyNameAttribute>();
            string name = propertyNameAttribute != null
                ? propertyNameAttribute.Name
                : propertyInfo.Name;

            return new Property(name, isRequired);
        }
    }
}