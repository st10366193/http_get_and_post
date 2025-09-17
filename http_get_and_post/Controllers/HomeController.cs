using System.Diagnostics;
using http_get_and_post.Models;
using Microsoft.AspNetCore.Mvc;

namespace http_get_and_post.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        // get method to prepare the form in index action method 
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        // the index action method to get form data using post method when the user click submit
        [HttpPost]
        public IActionResult Index(details user_details)
        {
            Console.WriteLine(user_details.name);
            return View(); 
        }

        public IActionResult Privacy()
        {
            return View();
        }

        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
