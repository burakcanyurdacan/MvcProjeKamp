using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Abstract
{
    public interface IContactService
    {
        List<Contact> GetContactList();
        void AddContact(Contact p);
        Contact GetByContactID(int id);
        void DeleteContact(Contact p);
        void UpdateContact(Contact p);
    }
}
