using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class HelloWorldController : Controller
    {
        //
        // GET: /HelloWorld/
        public IActionResult Index() => View();

        //
        // GET: /HelloWorld/Welcome/
        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Message"] = "Welcome " + name;
            ViewData["ID"] = "Your ID: " + ID;
            return View("Welcome");
        }
    }
}
