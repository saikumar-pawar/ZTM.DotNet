using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorPortfolio.Pages
{
    public class AboutModel : PageModel
    {
        public IList<string> ProgrammingLanguages { get; set; } = new List<string>();
        public void OnGet()
        {
            ProgrammingLanguages.Add("C#");
            ProgrammingLanguages.Add("Java");
            ProgrammingLanguages.Add("Javascript");
            ProgrammingLanguages.Add("Typescript");
        }
    }
}
