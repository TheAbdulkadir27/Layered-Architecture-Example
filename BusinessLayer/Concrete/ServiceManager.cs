using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class ServiceManager : IServiceServices
    {
        private readonly IServicesdal servicesdal;

        public ServiceManager(IServicesdal servicesdal)
        {
            this.servicesdal = servicesdal;
        }

        public void Delete(Service delete)
        {
            servicesdal.Delete(delete);
        }

        public Service getbyid(int id)
        {
            return servicesdal.Getbyid(id);
        }

        public List<Service> GetList()
        {
            return servicesdal.Getlist();
        }

        public void Update(Service Update)
        {
            servicesdal.Update(Update);
        }

        public void İnsert(Service insert)
        {
            servicesdal.İnsert(insert);
        }
    }
}
