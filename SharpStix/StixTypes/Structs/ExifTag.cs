using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpStix.StixTypes;

public readonly record struct ExifTag //todo, or use nicer library implementation -> lib would probably be better, then just use a converter for serialisation
{
    public string Name { get; }
    public string Value { get; }


    public Int54 ValueAsInteger() => throw new NotImplementedException();
}