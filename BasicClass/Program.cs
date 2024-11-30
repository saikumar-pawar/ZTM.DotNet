Person person1 = new Person("Jason");
Person person2 = new Person("Jack");

Console.WriteLine(person1.Name);
Console.WriteLine(person2.Name);
person1.PrintGreeting();
person2.PrintGreeting();
string greeting = person1.GetGreeting();
Console.WriteLine(greeting);

Math m = new Math();
Console.WriteLine(m.Sum(32, 46));

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

class Math
{
    public long Sum(int a, int b)
    {
        return (long)a + b;
    }
}