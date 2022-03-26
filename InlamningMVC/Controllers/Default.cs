using Microsoft.AspNetCore.Mvc;

namespace InlamningMVC.Controllers
{
    public class Default : Microsoft.AspNetCore.Mvc.Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
