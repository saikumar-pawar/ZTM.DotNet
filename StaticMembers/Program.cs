Person person1 = new Person("Jason");
Person person2 = new Person("Jack");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);
person1.PrintGreeting();
person2.PrintGreeting();
string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

Console.WriteLine(Math.Sum(32, 46));
Console.WriteLine(Math.PI);

class Person
{
    public Person(string name)
    {
        Name = name;
    }

    public string Name { get; private set; }

    public void PrintGreeting()
    {
        Console.WriteLine($"Hello, {Name}!");
    }

    public string GetGreeting()
    {
        return $"Hello, {Name}!";
    }
}

static class Math
{
    public static double PI { get { return 3.14d; } }
    public static long Sum(int a, int b)
    {
        return (long)a + b;
    }
}