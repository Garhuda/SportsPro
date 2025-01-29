using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class HomeController : Controller
    {
        //index method and current home page
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

    }
}