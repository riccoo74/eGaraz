using Microsoft.AspNetCore.Mvc;

namespace eGaraz.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}