var animals = new List<string> { "elephant", "rat", "monkey", "lion", "tiger", "cow" };

Console.WriteLine("Animals in Original order:");
foreach (var animal in animals)
{
    Console.WriteLine(animal);
}

Console.WriteLine("Animals in Ascending order:");
foreach (var animal in animals.OrderBy(a => a))
{
    Console.WriteLine(animal);
}

Console.WriteLine("Animals in Descending Order:");
foreach (var animal in animals.OrderByDescending(a => a))
{
    Console.WriteLine(animal);
}

var persons = new List<Person>
{
    new Person("sahil", "mishra"),
    new Person("rohit", "shetty"),
    new Person("ricky", "pointing"),
    new Person("rohit", "sharma")
};

Console.WriteLine("Persons in Original order:");
foreach (var person in persons)
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

Console.WriteLine("Persons in FirstName Ascending order:");
foreach (var person in persons.OrderBy(p => p.FirstName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

Console.WriteLine("Persons in FirstName Descending Order:");
foreach (var person in persons.OrderByDescending(p => p.FirstName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

Console.WriteLine("Persons in FirstName Ascending and LastName Ascending order:");
foreach (var person in persons.OrderBy(p => p.FirstName).ThenBy(p => p.LastName))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

animals.Reverse();
Console.WriteLine("Animals in Reverse of Original order:");
foreach (var animal in animals)
{
    Console.WriteLine(animal);
}

public record Person(string FirstName, string LastName);
