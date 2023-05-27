using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace PresentetionLayer.Controllers
{
    public class RoleController : Controller
    {
        private readonly RoleManager<AppRole> _roleManager;

        public RoleController(RoleManager<AppRole> roleManager)
        {
            _roleManager = roleManager;
        }

        public IActionResult Index()
        {
            var values = _roleManager.Roles.ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddRole(AppRole appRole)
        {
            var result = await _roleManager.CreateAsync(appRole);
            if(result.Succeeded)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteRole(int id)
        {
            var values = _roleManager.Roles.FirstOrDefault(x => x.Id == id);
            await _roleManager.DeleteAsync(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public  IActionResult UpdateRole(int id)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id == id);
            return View(value);
        }

        [HttpPost]
        public async Task<IActionResult> UpdateRole(AppRole role)
        {
            var value = _roleManager.Roles.FirstOrDefault(x=>x.Id == role.Id);
            value.Name = role.Name;
            await _roleManager.UpdateAsync(value);
            return RedirectToAction("Index");
        }
    }
}
