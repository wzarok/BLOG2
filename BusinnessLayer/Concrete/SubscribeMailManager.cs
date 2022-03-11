using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class SubscribeMailManager
    {
        Repository<SubscribeMail> reposubscribemail = new Repository<SubscribeMail>();
        public int BLAdd(SubscribeMail p)
        {
            
            if (p.MAIL.Length <= 10 || p.MAIL.Length>=51)
            {
                return -1;
            }
            return reposubscribemail.Insert(p);
        }
    }
}
