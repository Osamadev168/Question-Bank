using Microsoft.AspNetCore.Mvc;

namespace Testing_System.Controllers
{
    public class EditorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
