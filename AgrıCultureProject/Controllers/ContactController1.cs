using BusinessLayer.Concrete;
using DataAccessLayer.EntityFlamework;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;

namespace AgrıCultureProject.Controllers
{ 
    public class ContactController1 : Controller
    {
        ContactManager _contactManager = new ContactManager(new EFContactDal());
        public IActionResult Index()
        {
            return View(_contactManager.GetList());
        }
        [HttpGet]
        public IActionResult AddContact()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            _contactManager.İnsert(contact);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteContact(int id)
        {
            _contactManager.Delete(_contactManager.getbyid(id));
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateContact(int id)
        {
            return View(_contactManager.getbyid(id));
        }
        [HttpPost]
        public IActionResult UpdateContact(Contact contact)
        {
            _contactManager.Update(contact);
            return RedirectToAction("Index");
        }
    }
}
