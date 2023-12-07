using Microsoft.AspNetCore.Mvc;
using CookiesSalesSystem.Models;

namespace CookiesSalesSystem.Controllers
{
    public class SituationRoomController : Controller
    {
        public ActionResult LineMachineValueData()
        {

            static double[] GenerateRandomArray(Random random)
            {
                // 生成包含12個介於10到15之間的隨機數的陣列
                double[] randomArray = new double[12];
                for (int i = 0; i < randomArray.Length; i++)
                {
                    // 生成介於10到15之間的隨機數
                    double randomNumber = 10 + random.NextDouble() * (15-10);

                    // 將隨機數存入陣列
                    randomArray[i] = randomNumber;
                }
                return randomArray;
            }


            string[] AiMachine = { "機器1", "機器2", "3機器", "機器4", "機器5", "機器6",
                "機器8", "機器9", "機器10", "機器11", "機器12"};
            ViewBag.AiMachineLabel = AiMachine;

            Random random = new Random();
            List<Machine> Machines = new List<Machine>
            {
                new Machine
                {
                    AiMachine = "智能烘烤機",
                    MachineValue = GenerateRandomArray(random)
                },
                new Machine
                {
                    AiMachine = "智能殺菌機",
                    MachineValue = GenerateRandomArray(random)
                },
                new Machine
                {
                    AiMachine = "智能包裝機",
                    MachineValue = GenerateRandomArray(random)
                }

            };

            return View(Machines);
        }
    }
}
