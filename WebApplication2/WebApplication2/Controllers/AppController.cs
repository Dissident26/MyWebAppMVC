using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class AppController : Controller
    {
        [HttpGet]
        public IActionResult VetApplication()
        {
            ModelState.Clear();
            return View();
        }

        [HttpPost]
        public IActionResult VetApplication(DogViewModel model)
        {
            (string Name, int Age, string OwnerName, float Weight) = model;
            Console.WriteLine($"Name: {Name}, Age: {Age}, OwnerName: {OwnerName}, Weight: {Weight}");
            return VetApplication();
        }
    }
}
