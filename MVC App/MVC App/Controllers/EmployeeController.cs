using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;
namespace MVC_App.Controllers
{
    public class EmployeeController : Controller
    {



        public IActionResult Index()
        {
            var details = new Employee()
            {
                name = "Shahman",
                age = 78,
                description = "Hello from Shahman"
            };


            ViewData["Dets"] = details;
            return View();
        }
    }
}
