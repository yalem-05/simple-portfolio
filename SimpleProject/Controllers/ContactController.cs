using Microsoft.AspNetCore.Mvc;
using SimpleProject.Data;
using SimpleProject.Models;

namespace SimpleProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly ApplicationDbContext context;
        public ContactController(ApplicationDbContext _context) {
            this.context = _context;
        
        }
        [HttpGet]
        public IActionResult index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Coontact contact)
        {
            if (ModelState.IsValid)
            {
                context.Add(contact);
                context.SaveChanges();
                return View();
            }
           // List<Coontact> dbval = context.contacts.ToList();
            return View();
        }
    }
}
