using Microsoft.AspNetCore.Mvc;

namespace InlamningMVC.Controllers
{
    public class ServiceController : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
