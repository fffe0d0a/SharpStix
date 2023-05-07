using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpStix.Common;

namespace SharpStix.Serialisation;

public abstract class StixSerialiser
{
    public abstract string Serialise<T>(T value) where T : IStixType;

    public abstract T Deserialise<T>(string value) where T : IStixType;

    public abstract object Deserialise(Type type, string value);

    public abstract string Serialise(Type type, object value);
}

//public sealed class StixJsonSerialiser : StixSerialiser
//{

//}