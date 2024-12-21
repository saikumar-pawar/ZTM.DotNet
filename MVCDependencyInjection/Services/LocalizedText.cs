namespace MVCDependencyInjection.Services;

public class LocalizedText : ILocalizedText
{
    public string GetPageTitle(string language)
    {
        if (language =="en")
        {
            return "Welcom";
        }
        else if (language == "de")
        {
            return "Willkommen";
        }

        throw new NotSupportedException($"The language '{language}' is not supported.");
    }
}
