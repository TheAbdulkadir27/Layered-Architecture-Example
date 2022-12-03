using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.ViewComponents
{
    public class AboutPartial:ViewComponent
    {
        private readonly IAboutService aboutService;
        public AboutPartial(IAboutService aboutService)
        {
            this.aboutService = aboutService;
        }
        public IViewComponentResult Invoke()
        {
            return View(aboutService.GetList());
        }
    }
}
