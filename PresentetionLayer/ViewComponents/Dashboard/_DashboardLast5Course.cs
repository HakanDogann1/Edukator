using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Dashboard
{
    public class _DashboardLast5Course:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _DashboardLast5Course(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TGetLast5Course();
            return View(values);
        }
    }
}
