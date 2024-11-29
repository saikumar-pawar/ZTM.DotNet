string message = "Hello World";
Console.WriteLine(message);

string emptyMessage = string.Empty;

//string with double quote
string stringWithDoubleQuote = "This is a string with double quote: \"";
Console.WriteLine(stringWithDoubleQuote);

string filePath = "C:\\Movies";
Console.WriteLine(filePath);

string filePath2 = @"C:\Movies";
Console.WriteLine(filePath2);

//string length
Console.WriteLine($"no of characters in filepath [{filePath}]: {filePath.Length}");

//string concatenation
string firstName = "Ramesh";
string lastName = "Pawar";
string fullName = firstName + " " + lastName;
Console.WriteLine(fullName);

//string interpolation
string fullNameInterpolated = $"{firstName} {lastName}";
Console.WriteLine(fullNameInterpolated);
Console.WriteLine($"The result is: {20 * 4}");

//Substrings
string first4Characters = fullName.Substring(0, 3);
Console.WriteLine(first4Characters);
