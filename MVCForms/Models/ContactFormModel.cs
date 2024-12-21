using System.ComponentModel.DataAnnotations;

namespace MVCForms.Models;

public class ContactFormModel
{
    [Required]
    [StringLength(100)]
    public required string Name { get; set; }
    
    [Required]
    [EmailAddress]
    public required string Email { get; set; }
    
    [Required]
    [StringLength(500)]
    public string? Message { get; set; }
}
