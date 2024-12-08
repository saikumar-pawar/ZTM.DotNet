
var employees = new List<Employee>{
    new Employee("Jason", "Lee", "Sales"),
    new Employee("John", "Wick", "Development"),
    new Employee("Ricky", "Pointing", "Development"),
    new Employee("Sandeep", "Sharma", "Sales"),
    new Employee("Ramesh", "Pawar", "Development")
};

var employeesByDepartment = employees.GroupBy(p => p.Department);

foreach (var department in employeesByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($" {employee.FirstName} {employee.LastName}");
    }
}

public record Employee(string FirstName, string LastName, string Department);
