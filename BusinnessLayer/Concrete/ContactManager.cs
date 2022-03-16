using DataAccessLayer.Concrete;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinnessLayer.Concrete
{
    public class ContactManager
    {
        Repository<Contact> repocontact = new Repository<Contact>();

        public int BLContactAdd(Contact c)
        {
            if (c.ContactMail== "" || c.ContactMessage == "" || c.ContactName == "" || c.ContactSubject == "" || c.ContactSurName == "" || c.ContactMail.Length <= 10 || c.ContactSubject.Length <= 3){
                return -1;
            }
            return repocontact.Insert(c);
        }
    }
}
