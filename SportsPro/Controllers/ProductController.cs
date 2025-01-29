using Microsoft.AspNetCore.Mvc;

namespace SportsPro.Controllers
{
    public class ProductController : Controller
    {
        //index method and current home page
        public IActionResult List()
        {
            return View();
        }

    

    }
}