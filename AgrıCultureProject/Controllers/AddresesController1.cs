using BusinessLayer.Concrete;
using BusinessLayer.FluentValidator;
using DataAccessLayer.EntityFlamework;
using EntityLayer.concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.Controllers
{
    public class AddresesController1 : Controller
    {
        AddressesManager _addressesManager = new AddressesManager(new EfAdressDal());
        public IActionResult Index()
        {
            return View(_addressesManager.GetList());
        }
        [HttpGet]
        public IActionResult AddAddress()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAddress(Address address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result =  validationRules.Validate(address);
            if (result.IsValid)
            {
                _addressesManager.İnsert(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
        public IActionResult DeleteAdreses(int id)
        {
            _addressesManager.Delete(_addressesManager.getbyid(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAdreses(int id)
        {
            return View(_addressesManager.getbyid(id));
        }
        [HttpPost]
        public IActionResult UpdateAdreses(Address address)
        {
            AddressValidator validationRules = new AddressValidator();
            ValidationResult result = validationRules.Validate(address);
            if (result.IsValid)
            {
                _addressesManager.Update(address);
                return RedirectToAction("Index");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }
    }
}
