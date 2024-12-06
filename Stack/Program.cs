var countries = new Stack<string>();

countries.Push("Thailand");
countries.Push("China");
countries.Push("Japan");

var lastCountry = countries.Pop();
Console.WriteLine($"The last visited country was: {lastCountry}");

var previouslyVisitedCountry = countries.Peek();
Console.WriteLine($"The previously visited country was: {previouslyVisitedCountry}");

foreach (var country in countries)
{
    Console.WriteLine(country);
}
