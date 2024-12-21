using Microsoft.AspNetCore.Mvc;
using MVCDataPassing.Models;
using System.Diagnostics;

namespace MVCDataPassing.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        // View Model
        public IActionResult Person()
        {
            var person = new PersonViewModel(1, "nithin", "verma", [5, 10, 2]);
            return View(person);
        }

        // View Data
        public IActionResult Article()
        {
            ViewData["id"] = 4;
            ViewData["productName"] = "Watch";
            ViewData["price"] = 4678.928m;
            
            return View();
        }

        // View Bag
        public IActionResult Quote()
        {
            ViewBag.ProgrammersQuote = "Code is like humor. When you have to explain it, it's bad.";
            
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
