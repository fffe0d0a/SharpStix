using System.Text.Json;
using SharpStix.Services;
using SharpStix.StixObjects.CyberObservable;

namespace SharpStix.StixObjects;

public interface IHasPredefinedExtensions<T, T2> where T : IHasExtensions, IHasPredefinedExtensions<T, T2> where T2 : IPredefinedExtension //implementer has extensions and known predefined extensions
{
    public List<T2>? GetPredefinedExtensions()
    {
        T extendable = (T)this;

        Dictionary<string, JsonElement>? predefinedExtensions = extendable.Extensions?["extensions"].Deserialize<Dictionary<string, JsonElement>>(); //warn hard-coded property
        if (predefinedExtensions == null)
            return null;


        List<T2> extensions = new List<T2>();
        foreach (KeyValuePair<string, JsonElement> element in predefinedExtensions)
        {
            Type? t = StixTypeDiscriminationService.GetTypeFromDiscriminator(element.Key);
            T2 instance = (T2)element.Value.Deserialize(t); //warn missing serialisation options
        }


        //Type t = predefinedExtensions.RootElement[0]

        //key will be
        //var xx = q.Extensions.Where(x => x.)

        return new List<T2>();

        //return ((T)this).Extensions?.Where(x => x.)
    } //should I be a property that is populated on first access from the existing extensions?
}