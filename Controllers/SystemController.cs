using Microsoft.AspNetCore.Mvc;

namespace CookiesSalesSystem.Controllers
{
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
