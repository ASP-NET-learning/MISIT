using Microsoft.AspNetCore.Mvc;

namespace CookiesSalesSystem.Controllers
{
    public class CookiesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
