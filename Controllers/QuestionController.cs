using Microsoft.AspNetCore.Mvc;
using Testing_System.Data;
using Testing_System.Models;

namespace Testing_System.Controllers
{
    public class QuestionController : Controller
    {
        private readonly Test _test;
        public QuestionController(Test test) {

             _test = test;  
        }
        
        public IActionResult Index()
        {
            IEnumerable<Question> getQuestions = _test.Questions;    
            return View(getQuestions);
        }
        public IActionResult Create() {
            return View();
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Question obj)
        {
            if (ModelState.IsValid) {

                _test.Questions.Add(obj);
                _test.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult EditMCQ() {

            return View();
        }
        [HttpGet]
        public IActionResult EditMCQ(int? id) {
            if (id  == null || id == 0) {
                return NotFound();
            }
            var editMCQData = _test.Questions.Find(id);
            if (editMCQData == null) {

                return NotFound();
            }


            return View(editMCQData);

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult EditMCQ(Question obj)
        {
            if (ModelState.IsValid)
            {

                _test.Questions.Update(obj);
                _test.SaveChanges();

                return RedirectToAction("Index");
            }
            return View(obj);

        }
        public IActionResult DeleteMCQ()
        {

            return View();
        }

        [HttpGet]
        public IActionResult DeleteMCQ(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound();
            }
            var editMCQData = _test.Questions.Find(id);
            if (editMCQData == null)
            {

                return NotFound();
            }


            return View(editMCQData);

        }
        [HttpPost , ActionName("DeleteMCQ")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteMCQQ(int? id)
        {
            var questionObj = _test.Questions.Find(id);
             if  (questionObj == null)
            {
                return NotFound();
            }
                _test.Questions.Remove(questionObj);
                _test.SaveChanges();

                return RedirectToAction("Index");

        }

    }
}
