using System.ComponentModel.DataAnnotations;

namespace BlazorFormsValidation;

public class Employee
{
    [Required]
    [StringLength(20, MinimumLength = 4, ErrorMessage = "first name must be between 4 and 20 characters.")]
    public string? FirstName { get; set; }

    [Required]
    [StringLength(40, ErrorMessage = "last name must not be greater than 40 characters.")]
    public string? Lastname { get; set; }
    
    [Required]
    public DateOnly DateOfBirth { get; set; }
    
    [Required]
    [Range(10000, 100000, ErrorMessage = "salary must be in the range of 10000 and 100000")]
    public decimal Salary { get; set; }
}
