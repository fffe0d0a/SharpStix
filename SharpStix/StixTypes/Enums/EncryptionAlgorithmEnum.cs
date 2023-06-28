using System.Text.Json.Serialization;
using SharpStix.Common;
using SharpStix.Serialisation.Json.Converters;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
[JsonConverter(typeof(EnumerationConverterFactory))]
public sealed record EncryptionAlgorithmEnum : Enumeration<EncryptionAlgorithmEnum>, IStixEnum
{
    private const string TYPE = "encryption-algorithm-enum";

    public static readonly EncryptionAlgorithmEnum Aes256Gcm =
        new EncryptionAlgorithmEnum(0, "AES-256-GCM");

    public static readonly EncryptionAlgorithmEnum ChaCha20Poly1305 =
        new EncryptionAlgorithmEnum(1, "ChaCha20-Poly1305");

    public static readonly EncryptionAlgorithmEnum MineTypeIndicated =
        new EncryptionAlgorithmEnum(2, "mime-type-indicated");


    private EncryptionAlgorithmEnum(int value, string displayName) : base(value, displayName)
    {
    }

    public string Type => TYPE;

    public override string ToString() => base.ToString();
}