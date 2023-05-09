using System.Globalization;

namespace SharpStix.StixTypes;

public record Lang
{
    public Lang()
    {
        LanguageCode = "en";
    }

    public Lang(string lang)
    {
        try
        {
            _ = new CultureInfo(lang, false);
        }
        catch (Exception e)
        {
            throw new ArgumentException($"{lang} was not recognised as a valid language code.", nameof(lang), e);
        }

        LanguageCode = lang;
    }

    private string LanguageCode { get; }

    public override string ToString() => LanguageCode;
}