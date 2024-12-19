using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorActionResults.Pages
{
    public class MysteryModel : PageModel
    {
        public IActionResult OnGet(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                if (string.Equals(name, "ram", StringComparison.OrdinalIgnoreCase))
                {
                    return new OkResult();
                }
                if (string.Equals(name, "manual", StringComparison.OrdinalIgnoreCase))
                {
                    return Redirect("Manual");
                }
            }

            return NotFound();
        }
    }
}
