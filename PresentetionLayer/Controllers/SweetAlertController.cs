using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.Controllers
{
	public class SweetAlertController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
