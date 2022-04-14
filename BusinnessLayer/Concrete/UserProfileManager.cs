using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class UserProfileManager
    {
        Repository<Author> repouser = new Repository<Author>();
        Repository<Blog> repouserblog = new Repository<Blog>(); 
        public List<Author> GetAuthorByMail(string p)
        {
            return repouser.List(x => x.AuthorMail == p);
        }
        public List<Blog> GetBlogByAuthor(int id)
        {
            return repouserblog.List(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            Author author = repouser.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort = p.AboutShort;
            author.AuthorName = p.AuthorName;
            author.AuthorPass = p.AuthorPass;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorMail = p.AuthorMail;
            author.AuthorImage = p.AuthorImage;
            author.AuthoPhone = p.AuthoPhone;
            author.AuthorAbout = p.AuthorAbout;
            return repouser.Update(author);
        }
    }
}
