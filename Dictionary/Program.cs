var numbers = new Dictionary<int, string>
{
    { 1, "one" },
    { 2, "two" }
};

numbers.Add(3, "three");
numbers.Add(4, "four");
numbers[5] = "five";

foreach (var number in numbers)
{
    Console.WriteLine($"{number.Key}: {number.Value}");
}

foreach (var key in numbers.Keys)
{
    Console.WriteLine(key);
}

foreach (var val in numbers.Values)
{
    Console.WriteLine(val);
}

Console.WriteLine(numbers.ContainsKey(9));
