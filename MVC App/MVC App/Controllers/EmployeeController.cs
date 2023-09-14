using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;
namespace MVC_App.Controllers
{
    public class EmployeeController : Controller
    {



        [Route("/Employee/RoutedIndex")] //attribute routing overlapping conventional /Employee/RoutedIndex routing not allowing to work
        public IActionResult Index()
        {
            var Instance = new Employee
            {
                EmployeeName = "Shahman",
                EmployeeAge = 78,
            };


            ViewData["Instance"] = Instance;
            return View();
        }

        public IActionResult Methodtemp()
        {
            var details = new Employee
            {
                EmployeeName = "Shahman",
                EmployeeAge = 78,
            };

            TempData["Detsa"] = details;
            TempData["Temp"] = "ShahmanTemp";
            return View();
        }

        public IActionResult Methodtemp2()
        {
            

            if (TempData["Temp"] == null)
            {
                return RedirectToAction("Index"); // Redirect to the "Index" action
            }

            TempData["Temp2"] = TempData["Temp"].ToString();
            return View(); // Pass the TempData to the view
        }
    }
   
}

