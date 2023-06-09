using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PresentetionLayer.Models;
using System;
using System.IO;
using System.Threading.Tasks;

namespace PresentetionLayer.Controllers
{
    public class SettingsController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public SettingsController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.Name = values.Name;
            userEditViewModel.Surname = values.Surname;
            userEditViewModel.ImageUrl = values.ImageUrl;
            userEditViewModel.Email = values.Email;
            userEditViewModel.UserName = values.UserName;
            return View(userEditViewModel);
        }
        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel model)
        {
            var user =await _userManager.FindByNameAsync(User.Identity.Name);
            if(model.Image != null)
            {
                var resource=Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(model.Image.FileName);
                var imageName=Guid.NewGuid()+extension;
                var saveLocation = resource + "/wwwroot/userImage/"+imageName;
                var stream=new FileStream(saveLocation,FileMode.Create);
                await model.Image.CopyToAsync(stream);
                user.ImageUrl = "/userImage/" + imageName;
            }
            user.Surname=model.Surname;
            user.Name = model.Name;
            user.Email = model.Email;
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, model.Password);
            var result = await _userManager.UpdateAsync(user);

            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Category");
            }
            return View(); 
        }
    }
}
