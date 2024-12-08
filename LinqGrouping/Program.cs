
var persons = new List<Person>{
    new Person("Jason", "Lee", "Sales"),
    new Person("John", "Wick", "Development"),
    new Person("Ricky", "Pointing", "Development"),
    new Person("Sandeep", "Sharma", "Sales"),
    new Person("Ramesh", "Pawar", "Development")
};

var personsByDepartment = persons.GroupBy(p => p.Department);

foreach (var department in personsByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($" {employee.FirstName} {employee.LastName}");
    }
}

public record Person(string FirstName, string LastName, string Department);
