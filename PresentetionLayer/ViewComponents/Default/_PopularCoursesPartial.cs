using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _PopularCoursesPartial:ViewComponent
    {
        private readonly ICourseService _courseService;

        public _PopularCoursesPartial(ICourseService courseService)
        {
            _courseService = courseService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseService.TgetCourseWithByCategory();
            return View(values);
        }
    }
}
