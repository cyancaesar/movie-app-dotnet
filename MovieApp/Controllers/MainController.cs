using Microsoft.AspNetCore.Mvc;

namespace MovieApp.Controllers
{
    public class MainController : Controller
    {
        public string Index()
        {
            return "This is the main string that came from the MainController";
        }

        public string Secondary() => "This is a secondary action invoked from the MainController";
    }
}
