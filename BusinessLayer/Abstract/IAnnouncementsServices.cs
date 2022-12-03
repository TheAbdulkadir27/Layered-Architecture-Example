using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Abstract
{
    public interface IAnnouncementsServices: IGenericService<Announcement>
    {
        void AnnouncementStatustoFalse(int id);
        void AnnouncementStatustoTrue(int id);
    }
}
