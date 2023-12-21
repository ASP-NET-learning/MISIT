using CookiesSalesSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net;

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

        // GET: Equipment
        public ActionResult Index()
        {
            return View(_context.AiBom.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
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

        // GET: Equipment/OverviewDetails/1
        public ActionResult OverviewDetails(int? id)
        {
            if (id == null)
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

        // GET: Equipment/MachineDetails/1
        public ActionResult MachineDetails(int? id)
        {
            if (id == null)
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

        // GET: Equipment/NetworkDetails/1
        public ActionResult NetworkDetails(int? id)
        {
            if (id == null)
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

        // GET: Equipment/OperateDetails/1
        public ActionResult OperateDetails(int? id)
        {
            if (id == null)
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


        // GET: Equipment/AiDetails/1
        public ActionResult AiDetails(int? id)
        {
            if (id == null)
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


        // POST: Equipment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Equipment/MachineCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(
            [Bind("CreateID", "MachineID","MachineClass", "MachineName", 
            "SupervisorID", "EmployeeName","DepartmentName", 
            "WifiSSID", "WifiPassword", "IpAddress", "SubnetMask", "Gateway", "Dns",
                "Open_", "Speed", "Optimization",
                "AlgorithmName", "HyperparameterName", "CrossName")] AiBom ai)
        {

            _context.Add(ai);
            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException ex)
            {
                var innerException = ex.InnerException;
                while (innerException != null)
                {
                    Console.WriteLine(innerException.Message);
                    innerException = innerException.InnerException;
                }

            }
           
            return RedirectToAction(nameof(Index));
        }

    }
}