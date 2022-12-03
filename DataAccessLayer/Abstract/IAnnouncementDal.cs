using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Abstract
{
    public interface IAnnouncementDal:IGenericDal<Announcement>
    {
        void AnnouncementStatustoTrue(int id);
        void AnnouncementStatustoFalse(int id);
    }
}
