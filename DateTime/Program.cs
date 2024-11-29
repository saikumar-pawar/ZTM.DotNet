using System.Globalization;

DateTime dateOfBirth = new DateTime(1995, 1, 20);
Console.WriteLine(dateOfBirth);
Console.WriteLine(dateOfBirth.DayOfWeek);

//Computed Values
DateTime today = DateTime.Today;
DateTime now = DateTime.Now;
DateTime utcNow = DateTime.UtcNow;

//DateTime Parsing
DateTime localDate = DateTime.Parse("29-11-2024");
DateTime usDate = DateTime.Parse("11/29/2024", new CultureInfo("en-US"));

Console.WriteLine($"localDate: {localDate}\tusDate: {usDate}");

//DateTime Formatting
Console.WriteLine(dateOfBirth.ToString());
Console.WriteLine(dateOfBirth.ToString(new CultureInfo("en-US")));
Console.WriteLine(dateOfBirth.ToString("yyyy-MM-dd"));
