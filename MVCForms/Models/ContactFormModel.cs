namespace MVCForms.Models;

public class ContactFormModel
{
    public required string Name { get; set; }
    public required string Email { get; set; }
    public string? Message { get; set; }
}
