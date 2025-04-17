using Microsoft.AspNetCore.Mvc;

namespace PL.Controllers
{
    public class employeecontroller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
