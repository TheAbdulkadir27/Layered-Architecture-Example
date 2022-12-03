using AgrıCultureProject.Models;
using BusinessLayer.Abstract;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
namespace AgrıCultureProject.Controllers
{
    public class ServiceController1 : Controller
    {
        IServiceServices service;
        public ServiceController1(IServiceServices service)
        {
            this.service = service;
        }
        public IActionResult Index()
        {
            return View(service.GetList());
        }

        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddService(Service service2)
        {
            service.İnsert(service2);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteService(int id)
        {
            service.Delete(service.getbyid(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateService(int id)
        {
            return View(service.getbyid(id));
        }
        [HttpPost]
        public IActionResult UpdateService(Service service2)
        {
            service.Update(service2);
            return RedirectToAction("Index");
        }
        public IActionResult Deneme()
        {
            return View();
        }
    }
}
