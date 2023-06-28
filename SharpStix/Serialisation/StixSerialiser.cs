using SharpStix.Common;

namespace SharpStix.Serialisation;

public abstract class StixSerialiser //implementations other than StixJsonSerialiser will not work at present
{
    public abstract byte[] Serialise(object value, Type type);

    public abstract void SerialiseToFile(object value, Type type, string filePath);

    public abstract byte[] Serialise<T>(T value) where T : class, IStixType;

    public abstract void SerialiseToFile<T>(T value, string filePath) where T : class, IStixType;

    public abstract T? Deserialise<T>(string value) where T : class, IStixType;

    public abstract object? Deserialise(string value, Type type);

    public abstract T? DeserialiseFromFile<T>(string filePath) where T : class, IStixType;

    public abstract object? DeserialiseFromFile(Type type, string filePath);
}