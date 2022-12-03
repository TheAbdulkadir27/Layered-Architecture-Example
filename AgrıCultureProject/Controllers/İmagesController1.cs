using BusinessLayer.Abstract;
using BusinessLayer.FluentValidator;
using EntityLayer.concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.Controllers
{
    public class İmagesController1 : Controller
    {
        IİmagesService imagesService;
        public İmagesController1(IİmagesService imagesService)
        {
            this.imagesService = imagesService;
        }
        public IActionResult Index()
        {
            return View(imagesService.GetList());
        }
        [HttpGet]
        public IActionResult Addİmages()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Addİmages(İmage image)
        {
            İmageValidator validationRules = new İmageValidator();
            ValidationResult validation =  validationRules.Validate(image);
            if (validation.IsValid)
            {
                imagesService.İnsert(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        [HttpGet]
        public IActionResult Updateİmages(int id)
        {
            var image = imagesService.getbyid(id);
            return View(image);
        }
        [HttpPost]
        public IActionResult Updateİmages(İmage image)
        {
            İmageValidator validationRules = new İmageValidator();
            ValidationResult validation = validationRules.Validate(image);
            if (validation.IsValid)
            {
                imagesService.Update(image);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in validation.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        public IActionResult Deleteİmages(int id)
        {
            imagesService.Delete(imagesService.getbyid(id));
            return RedirectToAction("Index");
        }
    }
}
