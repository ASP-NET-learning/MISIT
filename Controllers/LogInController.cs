using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using CookiesSalesSystem.Models;
using Microsoft.AspNetCore.Identity;

namespace CookiesSalesSystem.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        
    }
}
