using System.Text.Json.Serialization;
using SharpStix.Extensions;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Vocabulary;

[JsonConverter(typeof(StixOpenVocabConverter<AccountType>))]
[StixTypeDiscriminator(TYPE)]
public sealed record AccountType(string Value) : StixOpenVocab(Value)
{
    private const string TYPE = "account-type-ov";

    public enum EAccountType
    {
        /// <summary>
        ///     Specifies a Facebook account.
        /// </summary>
        Facebook,

        /// <summary>
        ///     Specifies an LDAP account.
        /// </summary>
        Ldap,

        /// <summary>
        ///     Specifies a NIS account.
        /// </summary>
        Nis,

        /// <summary>
        ///     Specifies a OpenID account.
        /// </summary>
        Openid,

        /// <summary>
        ///     Specifies a RADIUS account.
        /// </summary>
        Radius,

        /// <summary>
        ///     Specifies a Skype account.
        /// </summary>
        Skype,

        /// <summary>
        ///     Specifies a TACACS account.
        /// </summary>
        Tacacs,

        /// <summary>
        ///     Specifies a Twitter account.
        /// </summary>
        Twitter,

        /// <summary>
        ///     Specifies a POSIX account.
        /// </summary>
        Unix,

        /// <summary>
        ///     Specifies a Windows local account.
        /// </summary>
        WindowsLocal,

        /// <summary>
        ///     Specifies a Windows domain account.
        /// </summary>
        WindowsDomain
    }

    public AccountType(EAccountType value) : this(value.ToString().PascalToKebabCase())
    {
    }

    public override string Type => TYPE;
}