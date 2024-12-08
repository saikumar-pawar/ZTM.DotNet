//1. Data Source
var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };

//2. Query Creation
//var evenNumbers = numbers.Where(num => num % 2 == 0);
//evenNumbers = numbers.Where(num => IsEvenNumber(num));
var evenNumbers = numbers.Where(num => num % 2 == 0).ToList();

numbers.Add(7);
numbers.Add(8);

//3. Query Execution
foreach (var evenNumber in evenNumbers)
{
    Console.WriteLine(evenNumber);
}

static bool IsEvenNumber(int number)
{
    return number % 2 == 0;
}
