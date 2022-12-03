using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.Models.ViewComponents
{
    public class _HeadPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
