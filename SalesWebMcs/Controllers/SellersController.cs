using Microsoft.AspNetCore.Mvc;

namespace SalesWebMcs.Controllers
{
    public class SellersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
