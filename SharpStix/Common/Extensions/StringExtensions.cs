using System.Buffers;
using System.Text;

namespace SharpStix.Extensions;

public static class StringExtensions
{
    public static bool ContainsNoneAsciiCharacters(this string text) => Encoding.UTF8.GetByteCount(text) != text.Length;

    /// <summary>
    ///     todo
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    /// <remarks>Modified from Pawel Maga's answer on https://stackoverflow.com/questions/22650248</remarks>
    public static string PascalToKebabCase(this string text)
    {
        char[]
            buffer = ArrayPool<char>.Shared.Rent(text.Length +
                                                 10); // define max size of the internal buffer, 10 = max 10 segments

        try
        {
            int resultLength = 0;
            for (int i = 0; i < text.Length; i++)
            {
                if (i > 0)
                {
                    if (char.IsUpper(text[i])) buffer[resultLength++] = '-';

                    if (char.IsNumber(text[i]) && !char.IsNumber(text[i - 1])) buffer[resultLength++] = '-';
                }

                buffer[resultLength++] = char.ToLowerInvariant(text[i]);
            }

            return new string(buffer.AsSpan()[..resultLength]);
        }
        finally
        {
            ArrayPool<char>.Shared.Return(buffer);
        }
    }

    public static string KebabToPascalCase(this string text)
    {
        char[] buffer = ArrayPool<char>.Shared.Rent(text.Length);

        try
        {
            int resultLength = 0;
            bool capNext = false;

            if (char.IsLower(text[0]))
                buffer[resultLength++] = char.ToUpperInvariant(text[0]);

            for (int i = 1; i < text.Length; i++)
            {
                if (text[i] == '-' && i != text.Length)
                {
                    capNext = true;
                    continue;
                }

                if (capNext)
                {
                    buffer[resultLength++] = char.ToUpperInvariant(text[i]);
                    capNext = false;
                    continue;
                }

                buffer[resultLength++] = text[i];
            }

            return new string(buffer.AsSpan()[..resultLength]);
        }
        finally
        {
            ArrayPool<char>.Shared.Return(buffer);
        }
    }
}