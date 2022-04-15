using BusinnessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BLOG.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        CategoryManager cm = new CategoryManager();
        [AllowAnonymous]
        public ActionResult Index()
        {
            var CategoryValues = cm.GetAll();
            return View(CategoryValues);
        }
        [AllowAnonymous]
        public PartialViewResult BlogCategoryList()
        {
            var CategoryValues = cm.GetAll();
            return PartialView(CategoryValues);
        }
        public ActionResult AdminCategoryList()
        {
            var categorylist = cm.GetAll();
            return View(categorylist);
        }
    }
}