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
        public List<Comment> CommentByStatusTrue()
        {
            return repocomment.List(x => x.CommentStatus == true);

        }

        public List<Comment> CommentListTrueByBlog(int id)
        {
            return repocomment.List(x => x.CommentStatus == true).Where(x => x.BlogID == id).ToList();
        }
        public int CommentAdd(Comment c)
        {
            if(c.CommentText.Length<=5 || c.CommentText.Length>=301 || c.CommentUser == "" || c.CommentMail == "" || c.CommentUser.Length <= 3)
            {
                return -1;
            }
            return repocomment.Insert(c); 
        }
        public List<Comment> CommentByStatusFalse()
        {
            return repocomment.List(x => x.CommentStatus == false);
        }
        public int ChangeCommentStatusToFalse(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = false;
            return repocomment.Update(comment);
        }
        public int ChangeCommentStatusToTrue(int id)
        {
            Comment comment = repocomment.Find(x => x.CommentID == id);
            comment.CommentStatus = true;
            return repocomment.Update(comment);
        }


    }
}
