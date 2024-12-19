using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RazorForms.Pages
{
    public class ModelBindingModel : PageModel
    {
        public string? UserName { get; set; }

        //public void OnPost(string userName, string password)
        //{
        //    UserName = userName;
        //}

        public void OnPost(FormData data)
        {
            UserName = data.UserName;
        }
    }

    public record FormData(string UserName, string Password);
}
