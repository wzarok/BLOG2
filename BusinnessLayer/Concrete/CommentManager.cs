using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class CommentManager
    {
        Repository<Comment> repocomment = new Repository<Comment>();

        public List<Comment> CommentList()
        {
            return repocomment.List();
        }
        public List<Comment> CommentByBlog(int id)
        {
            return repocomment.List(x => x.BlogID == id);
        }
        public int CommentAdd(Comment c)
        {
            if(c.CommentText.Length<=5 || c.CommentText.Length>=301 || c.CommentUser == "" || c.CommentMail == "" || c.CommentUser.Length <= 3)
            {
                return -1;
            }
            return repocomment.Insert(c);
        }
    }
}
