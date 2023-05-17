using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _HeaderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
