using System.Globalization;

namespace SharpStix.StixTypes;

//todo looks dirty; this is a struct replacing a string
public readonly record struct Language
{
    public Language()
    {
        LanguageCode = "en";
    }

    public Language(string lang)
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