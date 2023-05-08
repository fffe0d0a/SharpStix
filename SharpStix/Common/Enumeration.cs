using System.Collections.Frozen;
using System.Reflection;
using SharpStix.Common.Helpers;

namespace SharpStix.Common;

//Thank you to Josef Ottosson
//https://josef.codes/enumeration-class-in-c-sharp-using-records/
public abstract record Enumeration<T> : IComparable<T> where T : Enumeration<T>
{
    private static readonly Lazy<FrozenDictionary<int, T>> AllItems;
    private static readonly Lazy<FrozenDictionary<string, T>> AllItemsByName;

    static Enumeration()
    {
        AllItems = new Lazy<FrozenDictionary<int, T>>(() =>
        {
            return typeof(T)
                .GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly)
                .Where(x => x.FieldType == typeof(T))
                .Select(x => x.GetValue(null))
                .Cast<T>()
                .ToFrozenDictionary(x => x.Value, x => x);
        });
        AllItemsByName = new Lazy<FrozenDictionary<string, T>>(() =>
        {
            Dictionary<string, T> items = new Dictionary<string, T>(AllItems.Value.Count);
            foreach (KeyValuePair<int, T> item in AllItems.Value)
                if (!items.TryAdd(item.Value.DisplayName, item.Value))
                    throw new Exception(
                        $"DisplayName needs to be unique. '{item.Value.DisplayName}' already exists");
            return items.ToFrozenDictionary();
        });
    }

    protected Enumeration(int value, string displayName)
    {
        Value = value;
        DisplayName = displayName;
    }

    protected Enumeration(Enum @enum)
    {
        Value = Convert.ToInt32(@enum); //warn theoretically, this can be outside the range of an int.
        DisplayName = @enum.ToString();
    }

    public int Value { get; }
    public string DisplayName { get; }

    public int CompareTo(T? other)
    {
        return Value.CompareTo(other!.Value);
    }

    public override string ToString()
    {
        return DisplayName;
    }

    public static IEnumerable<T> GetAll()
    {
        return AllItems.Value.Values;
    }

    public static int AbsoluteDifference(Enumeration<T> firstValue, Enumeration<T> secondValue)
    {
        return Math.Abs(firstValue.Value - secondValue.Value);
    }

    public static T FromValue(int value)
    {
        if (AllItems.Value.TryGetValue(value, out T? matchingItem)) return matchingItem;
        throw new InvalidOperationException($"'{value}' is not a valid value in {typeof(T)}");
    }

    public static T FromDisplayName(string displayName)
    {
        if (AllItemsByName.Value.TryGetValue(displayName, out T? matchingItem)) return matchingItem;
        throw new InvalidOperationException($"'{displayName}' is not a valid display name in {typeof(T)}");
    }

    protected TEnum AsEnum<TEnum>() where TEnum : Enum
    {
        return EnumHelper<TEnum>.FromString(DisplayName);
    }
}