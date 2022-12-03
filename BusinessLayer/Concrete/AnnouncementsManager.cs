using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class AnnouncementsManager : IAnnouncementsServices
    {
        private readonly IAnnouncementDal announcementDal;

        public AnnouncementsManager(IAnnouncementDal announcementDal)
        {
            this.announcementDal = announcementDal;
        }

        public void AnnouncementStatustoFalse(int id)
        {
            announcementDal.AnnouncementStatustoFalse(id);
        }

        public void AnnouncementStatustoTrue(int id)
        {
            announcementDal.AnnouncementStatustoTrue(id);
        }
        public void Delete(Announcement delete)
        {
            announcementDal.Delete(delete);
        }
        public Announcement getbyid(int id)
        {
            return announcementDal.Getbyid(id);
        }
        public List<Announcement> GetList()
        {
            return announcementDal.Getlist();
        }
        public void Update(Announcement Update)
        {
            announcementDal.Update(Update);
        }
        public void İnsert(Announcement insert)
        {
            announcementDal.İnsert(insert);
        }
    }
}
