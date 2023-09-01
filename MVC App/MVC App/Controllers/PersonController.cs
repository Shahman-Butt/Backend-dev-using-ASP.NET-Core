using Microsoft.AspNetCore.Mvc;
using MVC_App.Models;

namespace MVC_App.Controllers
{
    public class PersonController : Controller
    {
        public IActionResult Index()
        {
            // Create a list of Person objects
            var people = new List<Person>
        {
            new Person { Id = 1, FirstName = "John", LastName = "Doe" },
            new Person { Id = 2, FirstName = "Jane", LastName = "Smith" }
        };

            // Pass the list of people to the view
            return View(people);
        }

        [HttpPost]
        public IActionResult Details(int id)
        {
            // Handle form submission and return the details view
            var person = new Person { Id = id, FirstName = "Sample", LastName = "Person" };
            return View(person);
        }





    }
}
