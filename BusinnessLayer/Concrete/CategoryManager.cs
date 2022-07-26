using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CategoryManager
    {
        Repository<Category> repocategory = new Repository<Category>();
        Repository<Blog> repoblog = new Repository<Blog>();
        public List<Category> GetAll()
        {
            return repocategory.List();
        }
        public List<Blog> GetBlogByCategory(int id)
        {
            return repoblog.List(x => x.CategoryID == id);
        }

        public int AddCategory(Category p)
        {

            if (p.CategoryName == "" || p.CategoryDetails=="")
            {
                return -1;
            }
            return repocategory.Insert(p);
        }

        public int Deletecat(int p)
        {
            Category blog = repocategory.Find(x => x.CategoryID == p);
            return repocategory.Delete(blog);
        }
    }
}
