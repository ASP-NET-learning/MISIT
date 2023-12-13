using CookiesSalesSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using X.PagedList;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace CookiesSalesSystem.Controllers
{
    public class SearchController : Controller
    {
        private readonly masterContext _context;
        private readonly ILogger<SearchController> _logger;
        public SearchController(ILogger<SearchController> logger, masterContext context)
        {
            _logger = logger;
            _context = context;
        }

        [HttpGet]
        [Route("Search/OrderList")]
        public IActionResult Index(int? page, string qOrderID, string qEmployeeID)
        {
            int pageSize = 5;

            var orders = from o in _context.Orders
                         select o;



            if (!string.IsNullOrEmpty(qOrderID) && !string.IsNullOrEmpty(qEmployeeID))
            {
                orders = orders.Where(o => o.OrderID == int.Parse(qOrderID)
                                    || o.EmployeeID == int.Parse(qEmployeeID));
            }
            else if (!string.IsNullOrEmpty(qOrderID))
            {
                orders = orders.Where(o => o.OrderID == int.Parse(qOrderID));
            }
            else  if (!string.IsNullOrEmpty(qEmployeeID))
            {
                orders = orders.Where(o => o.EmployeeID == int.Parse(qEmployeeID));
            }
            else
            { }

            var orderList = orders.ToPagedList(page ?? 1, pageSize);


            if (orderList.Count == 0)
            {
                ViewBag.Message = "未找到符合條件的訂單。";
            }

            return View(orderList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        
    }
}
