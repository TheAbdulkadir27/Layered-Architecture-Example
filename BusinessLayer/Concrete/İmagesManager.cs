using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class İmagesManager : IİmagesService
    {
        private readonly IİmagesDal imagesDal;

        public İmagesManager(IİmagesDal imagesDal)
        {
            this.imagesDal = imagesDal;
        }

        public void Delete(İmage delete)
        {
            imagesDal.Delete(delete);
        }

        public İmage getbyid(int id)
        {
            return imagesDal.Getbyid(id);
        }

        public List<İmage> GetList()
        {
            return imagesDal.Getlist();
        }

        public void Update(İmage Update)
        {
            imagesDal.Update(Update);
        }

        public void İnsert(İmage insert)
        {
            imagesDal.İnsert(insert);
        }
    }
}
