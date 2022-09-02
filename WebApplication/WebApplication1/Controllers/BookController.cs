using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            var book = new BookModelView("Война и мир", "Толстой Л.Н.", 666);

            return View(book);
        }
    }
}
