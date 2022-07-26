using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace BLOG.Controllers
{
    [AllowAnonymous]
    public class LoginController : Controller
    {
        // GET: Login
        [HttpGet]
        public ActionResult AuthorIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AuthorIndex(Author p)
        {
            Context c = new Context();
            var info = c.Authors.FirstOrDefault(x => x.AuthorMail == p.AuthorMail && x.AuthorPass == p.AuthorPass);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.AuthorMail, false);
                Session["Mail"] = info.AuthorMail.ToString();
                return RedirectToAction("Index", "User");
            }
            else
            {
                return RedirectToAction("AuthorIndex");
            }
        }
        [HttpGet]
        public ActionResult AdminIndex()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AdminIndex(Admin p)
        {
            Context c = new Context();
            var info = c.Admins.FirstOrDefault(x => x.AdminUser == p.AdminUser && x.AdminPass == p.AdminPass);
            if (info != null)
            {
                FormsAuthentication.SetAuthCookie(info.AdminUser, false);
                Session["UserName"] = info.AdminUser.ToString();
                return RedirectToAction("AdminBlogList", "Blog");
            }
            else
            {
                return RedirectToAction("AdminIndex","Login");
            }
        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Session.Abandon();
            return RedirectToAction("AdminIndex", "Login");
        }
    }
}