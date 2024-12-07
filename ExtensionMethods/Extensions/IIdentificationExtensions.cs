namespace ExtensionMethods.Extensions;

public static class IIdentificationExtensions
{
    public static bool HasId(this IIdentification identification)
    {
        return identification.Id > 0;
    }
}
