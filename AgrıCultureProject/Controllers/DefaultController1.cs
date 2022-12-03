using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.Controllers
{
    public class DefaultController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
