﻿using Edukator.BusinessLayer.Abstract;
using Edukator.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace PresentetionLayer.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IMailSubscribeService _mailSubscribeService;

        public DefaultController(IMailSubscribeService mailSubscribeService)
        {
            _mailSubscribeService = mailSubscribeService;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult AddMailSubscribe()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddMailSubscribe(MailSubscribe mailSubscribe)
        {
            _mailSubscribeService.TInsert(mailSubscribe);
            return RedirectToAction("Index");
        }

    }
}
