using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;
namespace MVC_App.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            var Instance = new Customer {
                CustomerName = "Shahman",
                CustomerAge = 00,
            };


            //ViewData["Dets"] = details;
            ViewBag.Instance = Instance;  
            
            return View();

        }
    }
}
