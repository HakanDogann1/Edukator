using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.ViewComponents.Default
{
    public class _SubscribePartial:ViewComponent
    {
        private readonly IMailSubscribeService _mailSubscribeService;

        public _SubscribePartial(IMailSubscribeService mailSubscribeService)
        {
            _mailSubscribeService = mailSubscribeService;
        }
        [HttpPost]
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
