using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal contactDal;

        public ContactManager(IContactDal contactDal)
        {
            this.contactDal = contactDal;
        }

        public void Delete(Contact delete)
        {
            contactDal.Delete(delete);
        }

        public Contact getbyid(int id)
        {
            return contactDal.Getbyid(id);
        }

        public List<Contact> GetList()
        {
            return contactDal.Getlist();
        }

        public void Update(Contact Update)
        {
            contactDal.Update(Update);
        }

        public void İnsert(Contact insert)
        {
            contactDal.İnsert(insert);
        }
    }
}
