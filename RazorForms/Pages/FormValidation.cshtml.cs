using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorForms.Pages
{
    public class FormValidationModel : PageModel
    {
        public ValidatedEmployee Employee { get; set; }

        public void OnPost(ValidatedEmployee employee)
        {
            //save data to database
            Console.WriteLine(employee.Name);
            ModelState.Clear();
        }
    }

    public class ValidatedEmployee
    {
        [Required]
        public required string Name { get; set; }

        [EmailAddress]
        [Required]
        public required string Email { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [MinLength(10)]
        public required string Password { get; set; }

        [DataType(DataType.Date)]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Send monthly newsletter")]
        public bool Newsletter { get; set; }
    }
}
