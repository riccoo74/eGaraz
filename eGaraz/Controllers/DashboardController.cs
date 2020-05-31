using Microsoft.AspNetCore.Mvc;

namespace eGaraz.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}