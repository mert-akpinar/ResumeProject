using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ProfileController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.tblProfile.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult AddProfile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProfile(tblProfile d)
        {
            db.tblProfile.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        public ActionResult DeleteProfile(int id)
        {
            var value = db.tblProfile.Find(id);
            db.tblProfile.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");


        }
        [HttpGet]
        public ActionResult UpdateProfile(int id)
        {
            var value = db.tblProfile.Find(id);
            return View(value);

        }
        [HttpPost]

        public ActionResult UpdateProfile(tblProfile b)
        {
            var value = db.tblProfile.Find(b.ProfileID);
            value.ProfileTitle = b.ProfileTitle;
            value.ProfileDescription = b.ProfileDescription;
            value.Name = b.Name;
            value.Mail = b.Mail;
            value.Adress = b.Adress;
            value.Phone = b.Phone;
            value.SocilaMedia1 = b.SocilaMedia1;
            value.SocialMedia2 = b.SocialMedia2;
            value.SocialMedia3 = b.SocialMedia3;
            value.SocialMedia4 = b.SocialMedia4;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

