using ExtensionMethods.Extensions;

Person person1 = new Person("Ricky", "Pointing");
Console.WriteLine(person1.FullName());
Console.WriteLine(person1.HasId());

public interface IIdentification
{
    int Id { get; }
}

public class Person : IIdentification
{
    public Person(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public int Id {
        get {
            return 6;
        }
    }
}
