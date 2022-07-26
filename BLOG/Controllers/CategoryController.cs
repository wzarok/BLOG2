using BusinnessLayer.Concrete;
using EntityLayer.Concrete;
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
        BlogManager bm = new BlogManager();
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
        [AllowAnonymous]
        public ActionResult CategoryDetail(int id)
        {

            var posttitle1 = cm.GetAll().OrderByDescending(z => z.CategoryID).Where(x => x.CategoryID == id).Select(y => y.CategoryName).FirstOrDefault();
            var postimage1 = cm.GetAll().OrderByDescending(z => z.CategoryID).Where(x => x.CategoryID == id).Select(y => y.CategoryDetails).FirstOrDefault();
            var debe = cm.GetAll().OrderByDescending(z => z.CategoryID).Where(x => x.CategoryID == id).Select(y => y.CategoryName).FirstOrDefault();
            ViewBag.title = posttitle1;
            ViewBag.detail = postimage1;
            ViewBag.debe = debe;
            var value = cm.GetBlogByCategory(id);
            return View(value);
        }
        [HttpGet]
        public ActionResult AddNewCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddNewCategory(Category p)
        {
            cm.AddCategory(p);
            return RedirectToAction("AdminCategoryList");
        }
        [AllowAnonymous]
        public ActionResult DeleteCategory(int id)
        {
            cm.Deletecat(id);
            return RedirectToAction("AdminCategoryList");
        }
    }
}