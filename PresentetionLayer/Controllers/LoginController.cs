using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentetionLayer.Models;
using System.Threading.Tasks;

namespace PresentetionLayer.Controllers
{
    public class LoginController : Controller
    {
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(LoginViewModel model)
        {
            var values =await _signInManager.PasswordSignInAsync(model.UserName,model.Password,false,false);
            if(values.Succeeded)
            {
                return RedirectToAction("Index", "MyCourse", new {area="Member"});
            }
            else
            {

            }
            return View();
        }
    }
}
