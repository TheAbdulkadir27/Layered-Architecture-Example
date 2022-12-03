using DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.ViewComponents
{
    public class SocialMediaPartial: ViewComponent
    {
        private readonly ISocialMediaDal socialMediaDal;

        public SocialMediaPartial(ISocialMediaDal socialMediaDal)
        {
            this.socialMediaDal = socialMediaDal;
        }
        public IViewComponentResult Invoke()
        {
            return View(socialMediaDal.Getlist());
        }
    }
}
