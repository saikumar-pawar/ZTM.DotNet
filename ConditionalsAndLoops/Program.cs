for (int i = 0; i < 20; i++)
{
    if (i > 10)
    {
        Console.WriteLine("value of i is greater than 10");
    }

    Console.WriteLine($"i: {i}");
}

string? input;
while (true)
{
    Console.Write("Enter your age: ");
    input = Console.ReadLine();

    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Invalid age");
    }
    else
    {
        if (int.TryParse(input, out int age))
        {
            Console.WriteLine("Happy birthday");
            break;
        }
        else
        {
            Console.WriteLine("Invalid age");
        }
    }
}
