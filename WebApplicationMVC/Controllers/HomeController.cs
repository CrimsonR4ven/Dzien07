using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
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
            List<User> users = new List<User>()
            {
                new User() {FirstName="Jacek", LastName="Placek"},
                new User() {FirstName="Janusz", LastName="Plackow"},
                new User() {FirstName="Joseph", LastName="Kowalski"},
                new User() {FirstName="Joshua", LastName="Kaczyński"}
            };
            return View(users);
        }

        public IActionResult Teapot()
        {
            return StatusCode(418, "jakiś błąd");
        }

        public IActionResult RedirectTest()
        {
            return RedirectToAction(nameof(Teapot));
        }

        public string Search1(string name, int year)
        {
            return $"name = {name}, year={year}";
        }
        [Route("Home/Search2/{name}")]
        public string Search1(string name)
        {
            return $"name = {name}";
        }
        public string Plain()
        {
            return "hello world";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult SessionExample()
        {
            HttpContext.Session.SetString("CurrentTime", DateTime.Now.ToString());
            HttpContext.Session.SetInt32("Counter", 1234);
            return View();
        }
    }
}