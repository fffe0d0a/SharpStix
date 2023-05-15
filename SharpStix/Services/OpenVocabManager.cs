using SharpStix.StixTypes.Vocabulary;
using System.Collections.Concurrent;

namespace SharpStix.Services;

internal static class OpenVocabManager<T> where T : StixOpenVocab
{
    private static readonly ConcurrentDictionary<string, T> Map = new ConcurrentDictionary<string, T>();

    public static bool TryGetValue(string key, out T? value) => Map.TryGetValue(key, out value);
    public static T GetValue(string key) => Map[key];
    public static bool TryAdd(T value) => Map.TryAdd(value.ToString(), value);
    public static T GetOrAdd(T value) => Map.GetOrAdd(value.ToString(), value);
    public static int Count => Map.Count;
}