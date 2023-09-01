using Microsoft.AspNetCore.Mvc;

namespace MVC_App.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            var details = new MVC_App.Models.Employee()
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
