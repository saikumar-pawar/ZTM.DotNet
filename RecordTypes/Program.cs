var person1 = new Person("Rakesh", "Sharma");
var person2 = new Person("Rakesh", "Sharma");
var person3 = new Person("Sanjay", "Sharma");

if (person1 == person2)
{
    Console.WriteLine("Persons are equal");
}

if (person2 == person3)
{
    Console.WriteLine($"{nameof(person2)} and {nameof(person3)} are equal");
}

public record Person(string FirstName, string LastName);
