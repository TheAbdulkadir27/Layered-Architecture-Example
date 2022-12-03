using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal aboutDal;
        public AboutManager(IAboutDal aboutDal)
        {
            this.aboutDal = aboutDal;
        }
        public void Delete(about delete)
        {
            aboutDal.Delete(delete);
        }

        public about getbyid(int id)
        {
           return aboutDal.Getbyid(id);
        }

        public List<about> GetList()
        {
            return aboutDal.Getlist();
        }

        public void Update(about Update)
        {
            aboutDal.Update(Update);
        }

        public void İnsert(about insert)
        {
            aboutDal.İnsert(insert);
        }
    }
}
