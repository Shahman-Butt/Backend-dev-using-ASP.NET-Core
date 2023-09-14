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
            //return View();
        }
        [HttpPost]
        public IActionResult Submit(string fullName)
        {
            // Split the full name into first name and last name
            var names = fullName.Split(' ');
            var firstName = names.Length > 0 ? names[0] : string.Empty;
            var lastName = names.Length > 1 ? names[1] : string.Empty;

            // Create a Person object with the extracted names
            var person = new Person { FirstName = firstName, LastName = lastName };

            // Pass the person object to the "Details" view
            return View("Submit", person);
        }

        [HttpPost]
        public IActionResult Details([FromBody]string fullName)
        {
            // Split the full name into first name and last name
            var names = fullName.Split(' ');
            var firstName = names.Length > 0 ? names[0] : string.Empty;
            var lastName = names.Length > 1 ? names[1] : string.Empty;

            // Create a Person object with the extracted names
            var person = new Person { FirstName = firstName, LastName = lastName };

            // Return a partial view with the person details
            return PartialView("_PersonDetailsPartial", person);
        }




        //public string message()
        //{
        //    return "hello Message";
        //}



    }
}
