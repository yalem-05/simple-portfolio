using Microsoft.AspNetCore.Mvc;
using SimpleProject.Models;

namespace SimpleProject.Controllers
{
    public class AboutController : Controller
    {
        private static About _about = new About();
        public IActionResult Index()
        {
         
            return View(_about);
        }

        [HttpPost]
        public IActionResult Index(About ab)
        {
            ab.total=ab.value++;
           
            return View(ab);
        }
    }
}
