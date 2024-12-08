
var employees = new List<Employee>{
    new Employee("Jason", "Lee", "Sales"),
    new Employee("John", "Wick", "Development"),
    new Employee("Ricky", "Pointing", "Development"),
    new Employee("Sandeep", "Sharma", "Sales"),
    new Employee("Ramesh", "Pawar", "Development")
};

var selectedEmployees = from employee in employees
                         where employee.FirstName.StartsWith("R")
                         orderby employee.LastName
                         select employee;

foreach (var employee in selectedEmployees)
{
    Console.WriteLine($"{employee.FirstName} {employee.LastName}");
}

var employeesByDepartment = from employee in employees
                            group employee by employee.Department
                            into groupedEmployees
                            orderby groupedEmployees.Key
                            select groupedEmployees;

foreach (var department in employeesByDepartment)
{
    Console.WriteLine($"Department: {department.Key}");

    foreach (var employee in department)
    {
        Console.WriteLine($" {employee.FirstName} {employee.LastName}");
    }
}
public record Employee(string FirstName, string LastName, string Department);
