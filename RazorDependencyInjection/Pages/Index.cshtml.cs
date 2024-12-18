using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorDependencyInjection.Services;

namespace RazorDependencyInjection.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ILuckyNumberService _luckyNumberservice;
        public int LuckyNumber { get; set; }

        public IndexModel(ILogger<IndexModel> logger, ILuckyNumberService luckyNumberservice)
        {
            _logger = logger;
            _luckyNumberservice = luckyNumberservice;
        }

        public void OnGet()
        {
            LuckyNumber = _luckyNumberservice.GetMyLuckyNumber();
        }
    }
}
