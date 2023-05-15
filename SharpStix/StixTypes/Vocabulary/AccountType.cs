using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AccountType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AccountType : StixOpenVocab, IFromString<AccountType>
{
    private const string TYPE = "account-type-ov";
    public static readonly AccountType Facebook = FromString("facebook");

    public static readonly AccountType Ldap = FromString("ldap");

    public static readonly AccountType Nis = FromString("nis");

    public static readonly AccountType OpenId = FromString("openid");

    public static readonly AccountType Radius = FromString("radius");

    public static readonly AccountType Skype = FromString("skype");

    public static readonly AccountType Tacacs = FromString("tacacs");

    public static readonly AccountType Twitter = FromString("twitter");

    public static readonly AccountType Unix = FromString("unix");

    public static readonly AccountType WindowsLocal = FromString("windows-local");

    public static readonly AccountType WindowsDomain = FromString("windows-domain");

    private AccountType(string Value) : base(Value)
    {
    }

    public override string Type => TYPE;

    public static AccountType FromString(string value)
    {
        if (OpenVocabManager<AccountType>.TryGetValue(value, out AccountType? vocab))
            return vocab!;

        vocab = new AccountType(value);
        OpenVocabManager<AccountType>.TryAdd(vocab);
        return vocab;
    }

    public override string ToString() => base.ToString();
}