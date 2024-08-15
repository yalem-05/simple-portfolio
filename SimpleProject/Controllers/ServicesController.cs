using Microsoft.AspNetCore.Mvc;

namespace SimpleProject.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
