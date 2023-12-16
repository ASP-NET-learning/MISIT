using Microsoft.AspNetCore.Mvc;

namespace CookiesSalesSystem.Controllers
{
    public class EquipmentController : Controller
    {
        public IActionResult Index(string MachineClass, string MachineName, string supervisorID, string EmployeeName, string DepartmentName, DateTime AddTime,
                                   string wifiSSID, string wifiPassword, string ipAddress, string subnetMask, string gateway, string dns,
                                   string Open, string Speed, string Optimization,
                                   string AlgorithmName, string HyperparameterName, string CrossName)
        {
            string[] Machines = { MachineClass, MachineName, supervisorID, EmployeeName, DepartmentName, AddTime.ToString("yyyy-MM-ddTHH:mm") };
            ViewBag.MachineClass = Machines[0];
            ViewBag.MachineName = Machines[1];
            ViewBag.supervisorID = Machines[2];
            ViewBag.EmployeeName = Machines[3];
            ViewBag.DepartmentName = Machines[4];
            ViewBag.AddTime = Machines[5];

            string[] Network = { wifiSSID, wifiPassword, ipAddress, subnetMask, gateway, dns };
            ViewBag.wifiSSID = Network[0];
            ViewBag.wifiPassword = Network[1];
            ViewBag.ipAddress = Network[2];
            ViewBag.subnetMask = Network[3];
            ViewBag.gateway = Network[4];
            ViewBag.dns = Network[5];

            string[] Operations = { Open, Speed, Optimization };
            ViewBag.Open = Operations[0];
            ViewBag.Speed = Operations[1];
            ViewBag.Optimization = Operations[2];

            string[] Ai = { AlgorithmName, HyperparameterName, CrossName };
            ViewBag.AlgorithmName = Ai[0];
            ViewBag.HyperparameterName = Ai[1];
            ViewBag.CrossName = Ai[2];

            return View();
        }
        public IActionResult Network()
        {
            return View();
        }

        public IActionResult Names()
        {
            return View();
        }

        public IActionResult Operation()
        {
            return View();
        }

        public IActionResult Ai()
        {
            return View();
        }
    }
}