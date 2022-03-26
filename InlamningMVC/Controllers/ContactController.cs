using Microsoft.AspNetCore.Mvc;

namespace InlamningMVC.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
