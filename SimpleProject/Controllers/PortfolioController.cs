using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Razor.Compilation;
using SimpleProject.Data;
using SimpleProject.Models;


namespace SimpleProject.Controllers
{
    public class PortfolioController : Controller
    {
        private readonly ApplicationDbContext _db;

        public PortfolioController(ApplicationDbContext db)
        {
            _db = db;   
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Portfolio objc)
        {
      
            if (ModelState.IsValid)
            {
                _db.Portfolios.Add(objc);
                _db.SaveChanges();
                return View();
            }
            return View();

        }
        public IActionResult AllData()
        {
            
            List<Portfolio> va = _db.Portfolios.ToList();
            return View(va);
         
        }


        public IActionResult Delet(int? id)
        {
            var obj = _db.Portfolios.Find(id);
            return View(obj);
        }
        [HttpPost ,ActionName("Delet")]
        public IActionResult DeletPOST(int? id)
        {
            var obj = _db.Portfolios.Find(id);
            _db.Portfolios.Remove(obj);
            _db.SaveChanges();
            return View();
        }


        public IActionResult Update(int? id)
        {
            var ob = _db.Portfolios.FirstOrDefault(u => u.Id == id);
            return View(ob);
        }
        [HttpPost]
        public IActionResult Update(Portfolio obj)
        {
            _db.Portfolios.Update(obj);
            _db.SaveChanges();
            return View();
        }
    }
}
