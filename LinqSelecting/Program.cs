var persons = new List<Person>{
    new Person("rahul", "tiwari", 32),
    new Person("rohit", "sharma", 38),
    new Person("yuvaraj", "singh", 42),
    new Person("sandeep", "sharma", 54),
    new Person("shashank", "singh", 24),
};

var lastNames = persons.Select(p => p.LastName);

Console.WriteLine("Persons Last Names:");
foreach (var lastName in lastNames)
{
    Console.WriteLine(lastName);
}

var ageBetween20And40 = persons.Where(p => p.Age >= 20 && p.Age <= 40).Select(p => p.Age);

Console.WriteLine();
foreach (var age in ageBetween20And40)
{
    Console.WriteLine(age);
}

var firstPerson = persons.First();

Console.WriteLine();
Console.WriteLine($"FirstPerson\nName: {firstPerson.FirstName} {firstPerson.LastName}\tAge: {firstPerson.Age}");

Console.WriteLine();
foreach (var person in persons.Skip(2).Take(2))
{
    Console.WriteLine($"{person.FirstName} {person.LastName}");
}

public record Person(string FirstName, string LastName, ushort Age);
