using Microsoft.AspNetCore.Mvc;

namespace Html2ViewsConversion.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }
    }
}
