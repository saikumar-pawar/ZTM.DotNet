var numbers = new List<int>();
numbers.Add(4);
numbers.Add(8);

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

var persons = new List<Person>();
persons.Add(new Person("Rohit"));
persons.Add(new Person("Krishna"));

foreach (var person in persons)
{
    Console.WriteLine(person.Name);
}

Console.WriteLine(persons[0].Name);

public class Person
{
    public Person(string name)
    {
        Name = name;
    }
    public string Name { get; set; }
}
