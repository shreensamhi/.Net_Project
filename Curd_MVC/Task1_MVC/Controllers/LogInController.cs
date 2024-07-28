using Microsoft.AspNetCore.Mvc;

namespace Task1_MVC.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Display()
        {
            return View("LogIn");
        }
    }
}
