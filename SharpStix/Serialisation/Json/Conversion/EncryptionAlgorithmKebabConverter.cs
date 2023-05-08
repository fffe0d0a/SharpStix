//using System.Text.Json;
//using System.Text.Json.Serialization;
//using SharpStix.StixTypes.Enums;

//namespace SharpStix.Serialisation.Json.Conversion;

//public class EncryptionAlgorithmKebabConverter : JsonConverter<EEncryptionAlgorithm>
//{
//    private const string AES = "AES-256-GCM";
//    private const string CHACHA = "ChaCha20-Poly1305";
//    private const string MIME = "mime-type-indicated";

//    public override EEncryptionAlgorithm Read(ref Utf8JsonReader reader, Type typeToConvert,
//        JsonSerializerOptions options)
//    {
//        string readString = reader.GetString()!;
//        return readString switch
//        {
//            AES => EEncryptionAlgorithm.Aes256Gcm,
//            CHACHA => EEncryptionAlgorithm.ChaCha20Poly1305,
//            MIME => EEncryptionAlgorithm.MimeTypeIndicated,
//            _ => throw new ArgumentOutOfRangeException(nameof(readString), readString, "Unhandled switch parameter.")
//        };
//    }

//    public override void Write(Utf8JsonWriter writer, EEncryptionAlgorithm value, JsonSerializerOptions options)
//    {
//        switch (value)
//        {
//            case EEncryptionAlgorithm.Aes256Gcm:
//                writer.WriteStringValue(AES);
//                break;
//            case EEncryptionAlgorithm.ChaCha20Poly1305:
//                writer.WriteStringValue(CHACHA);
//                break;
//            case EEncryptionAlgorithm.MimeTypeIndicated:
//                writer.WriteStringValue(MIME);
//                break;
//            default:
//                throw new ArgumentOutOfRangeException(nameof(value), value, "Unhandled switch parameter.");
//        }
//    }
//}

