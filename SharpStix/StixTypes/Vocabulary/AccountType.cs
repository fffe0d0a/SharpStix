using System.Text.Json.Serialization;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AccountType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AccountType : StixOpenVocab
{
    public static readonly AccountType Facebook = new AccountType("facebook");

    public static readonly AccountType Ldap = new AccountType("ldap");

    public static readonly AccountType Nis = new AccountType("nis");

    public static readonly AccountType OpenId = new AccountType("openid");

    public static readonly AccountType Radius = new AccountType("radius");

    public static readonly AccountType Skype = new AccountType("skype");

    public static readonly AccountType Tacacs = new AccountType("tacacs");

    public static readonly AccountType Twitter = new AccountType("twitter");

    public static readonly AccountType Unix = new AccountType("unix");

    public static readonly AccountType WindowsLocal = new AccountType("windows-local");

    public static readonly AccountType WindowsDomain = new AccountType("windows-domain");

    public AccountType(string Value) : base(Value)
    {
    }


    private const string TYPE = "account-type-ov";

    public override string Type => TYPE;

    public override string ToString() => base.ToString();

    public void Deconstruct(out string Value)
    {
        Value = this.Value;
    }
}