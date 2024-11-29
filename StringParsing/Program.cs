using System.Globalization;

string luckyNumber = "12";
int parsedLuckyNumber = int.Parse(luckyNumber);

double temperature = double.Parse("32.4");

CultureInfo cultureInfo = new CultureInfo("de-DE");
temperature = double.Parse("28.6", cultureInfo);

temperature = double.Parse("28,6", cultureInfo);
Console.ReadKey();
