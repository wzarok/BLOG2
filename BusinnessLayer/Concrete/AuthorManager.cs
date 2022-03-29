using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class AuthorManager
    {
        Repository<Author> repoauthor = new Repository<Author>();
        public List<Author> GetAll()
        {
            return repoauthor.List();
        }
        public int AddAuthorBL(Author p)
        {
            if (p.AuthorName == "" || p.AboutShort == "" || p.AuthorTitle == "")
            {
                return -1;
            }
            return repoauthor.Insert(p);
        }
        public Author FindAuthor(int id)
        {
            return repoauthor.Find(x => x.AuthorID == id);
        }
        public int EditAuthor(Author p)
        {
            Author author = repoauthor.Find(x => x.AuthorID == p.AuthorID);
            author.AboutShort = p.AboutShort;
            author.AuthorName = p.AuthorName;
            author.AuthorPass = p.AuthorPass;
            author.AuthorTitle = p.AuthorTitle;
            author.AuthorMail = p.AuthorMail;
            author.AuthorImage = p.AuthorImage;
            author.AuthoPhone = p.AuthoPhone;
            author.AuthorAbout = p.AuthorAbout;
            return repoauthor.Update(author);
        }
    }
}
