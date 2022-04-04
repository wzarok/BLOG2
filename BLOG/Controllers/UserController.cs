using BusinnessLayer.Concrete;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLOG.Controllers
{
    public class UserController : Controller
    {
        // GET: User
        UserProfileManager userprofile = new UserProfileManager();


        public ActionResult Index()
        {
         
            return View();
        }
        public PartialViewResult Partial1(string p)
        {
            p = (string)Session["Mail"];
            var profilevalues = userprofile.GetAuthorByMail(p);
            return PartialView(profilevalues);
        }
        public ActionResult BlogList(string p)
        {
            p = (string)Session["Mail"];
            Context c = new Context();
            int id = c.Authors.Where(x => x.AuthorMail == p).Select(y => y.AuthorID).FirstOrDefault();
            var blogs = userprofile.GetBlogByAuthor(id);
            return View(blogs);
        }
    }
}