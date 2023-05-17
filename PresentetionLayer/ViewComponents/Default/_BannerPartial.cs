using Edukator.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _BannerPartial:ViewComponent
    {
        private readonly IFeatureService _featureService;

        public _BannerPartial(IFeatureService featureService)
        {
            _featureService = featureService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _featureService.TGetList();
            return View(values);
        }
    }
}
