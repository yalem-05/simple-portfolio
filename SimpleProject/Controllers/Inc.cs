using Microsoft.AspNetCore.Mvc;

namespace SimpleProject.Controllers
{
    public class Inc : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
