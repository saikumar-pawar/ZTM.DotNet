namespace CustomExceptionTypes;

public class InvalidUserNameException : Exception
{
    public string? UserName { get; set; }

    public InvalidUserNameException(string? userName) : base($"The username '{userName}' is invalid.")
    {
        UserName = userName;
    }

    public InvalidUserNameException(string? userName, string? message) : base(message)
    {
        UserName = userName;
    }

    public InvalidUserNameException(string? userName, string? message, Exception? innerException) : base(message, innerException)
    {
        UserName = userName;
    }
}
