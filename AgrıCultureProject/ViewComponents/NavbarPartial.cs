using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.ViewComponents
{
    public class NavbarPartial: ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
