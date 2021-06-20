using BusinessLogicLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDAL _contactDal;

        public ContactManager(IContactDAL contactDal)
        {
            _contactDal = contactDal;
        }

        public void AddContact(Contact p)
        {
            _contactDal.Insert(p);
        }

        public void DeleteContact(Contact p)
        {
            _contactDal.Delete(p);
        }

        public Contact GetByContactID(int id)
        {
            return _contactDal.GetByID(x => x.ContactId == id);
        }

        public List<Contact> GetContactList()
        {
            return _contactDal.List();
        }

        public void UpdateContact(Contact p)
        {
            _contactDal.Update(p);
        }
    }
}
