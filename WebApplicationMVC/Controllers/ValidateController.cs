using Microsoft.AspNetCore.Mvc;
using WebApplicationMVC.Models;

namespace WebApplicationMVC.Controllers
{
    public class ValidateController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View(new Member());
        }
        [HttpPost]
        public IActionResult Index(Member member)
        {
            if (ModelState.IsValid)
            {
                return StatusCode(418, "oh Wow");
            }
            return View(member);
        }
    }
}
