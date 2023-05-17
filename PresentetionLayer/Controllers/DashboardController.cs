using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
