using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AddressesManager : AddressServices
    {
        private readonly IAddressdal addressdal;

        public AddressesManager(IAddressdal addressdal)
        {
            this.addressdal = addressdal;
        }

        public void Delete(Address delete)
        {
            addressdal.Delete(delete);
        }

        public Address getbyid(int id)
        {
            return addressdal.Getbyid(id);
        }

        public List<Address> GetList()
        {
            return addressdal.Getlist();
        }

        public void Update(Address Update)
        {
            addressdal.Update(Update);
        }

        public void İnsert(Address insert)
        {
            addressdal.İnsert(insert);
        }
    }
}
