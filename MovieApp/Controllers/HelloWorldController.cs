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
            TempData["THIS_IS_DANGEROUS_DATA_TRANSFER"] = "Read the key";
            return View("Welcome");
        }
    }
}
