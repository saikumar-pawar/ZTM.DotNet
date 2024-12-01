
Person person1 = new Person("Suresh");
Employee employee1 = new Employee("Rishi", "CTO");
Console.WriteLine($"{person1.Name}: {person1.GetId()}");
Console.WriteLine($"{employee1.Name}: {employee1.GetId()}");

public interface ISalary
{
    decimal GetSalary();
}

public class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public virtual string GetId()
    {
        return Name.ToLower();
    }
}

public class Employee : Person, ISalary
{
    public string Role { get; set; }

    public Employee(string name, string role) : base(name)
    {
        Role = role;
    }

    public override string GetId()
    {
        return $"{Role.ToLower()}-{base.GetId()}";
    }

    public decimal GetSalary()
    {
        return 10000;
    }
}
