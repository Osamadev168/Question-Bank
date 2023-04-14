using Microsoft.AspNetCore.Mvc;
using Testing_System.Data;
using Testing_System.Models;

namespace Testing_System.Controllers
{
    public class BlankController : Controller
    {
        private readonly Test _test;
        public BlankController(Test test) {
            _test = test;
        }

        public IActionResult Index()
        {
            IEnumerable<Blank> getQuestions = _test.Blanks;
            return View(getQuestions);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Blank obj)
        {
            if (ModelState.IsValid)
            {

                _test.Blanks.Add(obj);
                _test.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
    }
    
}
