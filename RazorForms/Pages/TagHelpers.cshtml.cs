using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace RazorForms.Pages
{
    public class TagHelpersModel : PageModel
    {
        public Employee Employee { get; set; }

        public void OnPost(Employee employee)
        {
            //save data to database
            Console.WriteLine(employee.Name);
        }
    }

    public class Employee
    {
        public required string Name { get; set; }
        
        [EmailAddress]
        public required string Email { get; set; }
        
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Send monthly newsletter")]
        public bool Newsletter { get; set; }
    }
}
