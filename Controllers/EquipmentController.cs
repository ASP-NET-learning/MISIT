using CookiesSalesSystem.Models;
using Microsoft.AspNetCore.Mvc;

namespace CookiesSalesSystem.Controllers
{
    public class EquipmentController : Controller
    {
        private readonly masterContext _context;
        private readonly ILogger<EquipmentController> _logger;
        public EquipmentController(ILogger<EquipmentController> logger, masterContext context)
        {
            _logger = logger;
            _context = context;
        }

        // GET: Ai
        public ActionResult Index()
        {
            return View(_context.AiBom.ToList());
        }

        // GET: Ai/Details/5
        public ActionResult Details(int? id)
        {
            if(id == null)
            {
                return NotFound();
            }
            var AiBomDetails = _context.AiBom.FirstOrDefault(m => m.ID == id);
            if (AiBomDetails == null)
            {
                return NotFound();
            }

            return View(AiBomDetails);
        }

    }
}