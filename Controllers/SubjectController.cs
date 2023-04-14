using Microsoft.AspNetCore.Mvc;

namespace Testing_System.Controllers
{
    public class SubjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
