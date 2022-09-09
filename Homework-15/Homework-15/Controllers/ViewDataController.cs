using Microsoft.AspNetCore.Mvc;
using Homework_15.Models;

namespace Homework_15.Controllers
{
    public class ViewDataController : Controller
    {
        public IActionResult Index()
        {
            List<FishModel> fishList = new()
            {
                new FishModel() { Name = "Рыба Карась", Speed = 3, Weight = 3 },
                new FishModel() { Name = "Шевелись Плотва", Speed = 5, Weight = 2 },
                new FishModel() { Name = "Здоровенный Язь", Speed = 2, Weight = 3 },
            };

            ViewData["FishList"] = fishList;

            return View();
        }
    }
}
