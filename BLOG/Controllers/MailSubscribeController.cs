using BusinnessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLOG.Controllers
{
    public class MailSubscribeController : Controller
    {
        // GET: MailSubscribe
        [AllowAnonymous]
        [HttpGet]
        public PartialViewResult AddMail()
        {
            return PartialView();
        }
        [AllowAnonymous]
        [HttpPost]
        public PartialViewResult AddMail(SubscribeMail p)
        {
            SubscribeMailManager sm = new SubscribeMailManager();
            sm.BLAdd(p);
            return PartialView();
        }
    }
}