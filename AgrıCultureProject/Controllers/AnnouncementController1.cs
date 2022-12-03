using BusinessLayer.Abstract;
using EntityLayer.concrete;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AgrıCultureProject.Controllers
{
    public class AnnouncementController1 : Controller
    {
        IAnnouncementsServices announcementsServices;

        public AnnouncementController1(IAnnouncementsServices announcementsServices) => this.announcementsServices = announcementsServices;
        public IActionResult Index()
        {
            return View(announcementsServices.GetList());
        }

        [HttpGet]
        public IActionResult AddAnnouncement()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddAnnouncement(Announcement announcement)
        {
            announcement.Date = DateTime.Parse(DateTime.Now.ToShortDateString());
            announcement.Status = false;
            announcementsServices.İnsert(announcement);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteAnnouncement(int id)
        {
            announcementsServices.Delete(announcementsServices.getbyid(id));
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdateAnnouncement(int id)
        {
             return View(announcementsServices.getbyid(id));
        }
        [HttpPost]
        public IActionResult UpdateAnnouncement(Announcement announcement)
        {
            announcementsServices.Update(announcement);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusFalse(int id)
        {
            announcementsServices.AnnouncementStatustoFalse(id);
            return RedirectToAction("Index");
        }
        public IActionResult ChangeStatusTrue(int id)
        {
            announcementsServices.AnnouncementStatustoTrue(id);
            return RedirectToAction("Index");
        }
    }
}