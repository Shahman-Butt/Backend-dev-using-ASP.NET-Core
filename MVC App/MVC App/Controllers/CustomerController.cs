using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;
namespace MVC_App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var details = new Customer()
            {
                name = "Shahman",
                age = 00,
            };


            //ViewData["Dets"] = details;
            ViewBag.Details = details;  
            
            return View();

        }
    }
}
