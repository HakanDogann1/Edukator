using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Dashboard
{
    public class _DashboardCourseRegisterPartial:ViewComponent
    {
        private readonly ICourseRegisterService _courseRegisterService;

        public _DashboardCourseRegisterPartial(ICourseRegisterService courseRegisterService)
        {
            _courseRegisterService = courseRegisterService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _courseRegisterService.TCourseRegisterWithCoursesAndUsers();
            return View(values);
        }
    }
}
