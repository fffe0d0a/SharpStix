using SharpStix.Common;
using SharpStix.Services;

namespace SharpStix.StixTypes.Enums;

[StixTypeDiscriminator(TYPE)]
public sealed record EncryptionAlgorithmEnum : Enumeration<EncryptionAlgorithmEnum>, IStixEnum
{
    private const string TYPE = "encryption-algorithm-enum";

    public static readonly EncryptionAlgorithmEnum Aes256Gcm = new EncryptionAlgorithmEnum(EEncryptionAlgorithm.Aes256Gcm);
    public static readonly EncryptionAlgorithmEnum ChaCha20Poly1305 = new EncryptionAlgorithmEnum(EEncryptionAlgorithm.ChaCha20Poly1305);
    public static readonly EncryptionAlgorithmEnum MineTypeIndicated = new EncryptionAlgorithmEnum(EEncryptionAlgorithm.MimeTypeIndicated);

    private enum EEncryptionAlgorithm
    {
        Aes256Gcm,
        ChaCha20Poly1305,
        MimeTypeIndicated
    }

    private EncryptionAlgorithmEnum(EEncryptionAlgorithm value) : base(value)
    {
    }

    public override string ToString()
    {
        return AsEnum<EEncryptionAlgorithm>() switch
        {
            EEncryptionAlgorithm.Aes256Gcm => "AES-256-GCM",
            EEncryptionAlgorithm.ChaCha20Poly1305 => "ChaCha20-Poly1305",
            EEncryptionAlgorithm.MimeTypeIndicated => "mime-type-indicated",
            _ => throw new Exception("Library error")
        };
    }

    public string Type => TYPE;
}
