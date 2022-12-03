using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete.Repository;
using DataAccessLayer.Context;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntityFlamework
{
    public class EfAnnouncementsdal : GenericRepository<Announcement>, IAnnouncementDal
    {
        public void AnnouncementStatustoFalse(int id)
        {
            using (var context = new DbDataContext())
            {
                Announcement announcement =  context.Announcements.Find(id);
                announcement.Status = false;
                context.SaveChanges();
            }
        }

        public void AnnouncementStatustoTrue(int id)
        {
            using (var context = new DbDataContext())
            {
                Announcement announcement = context.Announcements.Find(id);
                announcement.Status = true;
                context.SaveChanges();
            }
        }
    }
}
