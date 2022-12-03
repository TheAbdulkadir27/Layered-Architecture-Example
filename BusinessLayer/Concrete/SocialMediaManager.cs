using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Concrete
{
    public class SocialMediaManager : SocialMediaService
    {
        ISocialMediaDal socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }

        public void Delete(SocialMedia delete)
        {
            socialMediaDal.Delete(delete);
        }

        public SocialMedia getbyid(int id)
        {
            return socialMediaDal.Getbyid(id);
        }

        public List<SocialMedia> GetList()
        {
            return socialMediaDal.Getlist();
        }

        public void Update(SocialMedia Update)
        {
            socialMediaDal.Update(Update);
        }

        public void İnsert(SocialMedia insert)
        {
            socialMediaDal.İnsert(insert);
        }
    }
}
