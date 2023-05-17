using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Dashboard
{
    public class _ChartDashboardPartial:ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
