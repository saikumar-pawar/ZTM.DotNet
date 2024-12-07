namespace ExtensionMethods.Extensions;

public static class PersonExtensions
{
    public static string FullName(this Person person)
    {
        return $"{person.FirstName} {person.LastName}";
    }
}
