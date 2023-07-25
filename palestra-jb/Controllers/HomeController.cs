using Microsoft.AspNetCore.Mvc;
using palestra_jb.Models;
using System.Diagnostics;

namespace palestra_jb.Controllers
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task<string> Sortear()
        {
            HttpClient httpClient = new HttpClient();
            return await httpClient.GetStringAsync("https://localhost:7031/joaobley/sortear");
        }
    }
}