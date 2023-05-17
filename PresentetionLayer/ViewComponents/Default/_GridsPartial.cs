using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _GridsPartial:ViewComponent
    {
        private readonly IServiceService _service;

        public _GridsPartial(IServiceService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.TGetList();
            return View(values);
        }
    }
}
