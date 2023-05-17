using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.Areas.Member.Controllers
{
    [Area("Member")]
    public class MemberLayout : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public MemberLayout(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
           
            return View();
        }

        public PartialViewResult MemberSidebarPartial()
        {
            
            return PartialView();
        }
    }
}
