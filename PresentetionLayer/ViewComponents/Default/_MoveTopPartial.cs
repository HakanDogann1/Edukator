using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _MoveTopPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
