using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Dashboard
{
    public class _DashboardCalenderPartial:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
