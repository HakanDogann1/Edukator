using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _TestimonialsPartial:ViewComponent
    {
        private readonly IReviewService _reviewService;

        public _TestimonialsPartial(IReviewService reviewService)
        {
            _reviewService = reviewService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _reviewService.TGetList();
            return View(values);
        }
    }
}
