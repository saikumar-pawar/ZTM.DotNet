namespace CustomExceptionTypes;

public class Program
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Username: ");
        var userInput = Console.ReadLine();

        try
        {
            var userName = GetNormalizedUserName(userInput);
            Console.WriteLine($"Username: {userName}");
        }
        catch (InvalidUserNameException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static string GetNormalizedUserName(string? userName)
    {
        if (string.IsNullOrWhiteSpace(userName) || userName.Length < 6)
        {
            throw new InvalidUserNameException(userName);
        }

        return userName.ToLower();
    }
}
