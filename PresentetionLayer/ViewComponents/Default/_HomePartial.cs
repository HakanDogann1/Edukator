using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _HomePartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
