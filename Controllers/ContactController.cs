using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.Mvc;
namespace ResumeProject.Controllers
{
    public class ContactController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.tblContact.ToList();

            return View(values);
        }
        public ActionResult DeleteContact(int id)
        {
            var values = db.tblContact.Find(id);
            db.tblContact.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateContact(int id)
        {
            var values = db.tblContact.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateContact(tblContact c)
        {
            var values = db.tblContact.Find(c.ContactID);
            values.NameSurname = c.NameSurname;
            values.Mail = c.Mail;
            values.Subject = c.Subject;
            values.Message = c.Message;
            values.Date = c.Date;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult SendMessage()
        {
            List<SelectListItem> values = (from x in db.tblCategory.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.CategoryName,
                                               Value = x.CategoryID.ToString()
                                           }).ToList();
            ViewBag.v = values;
            return View();
        }
        [HttpPost]
        public ActionResult SendMessage(tblContact p)
        {
            p.Date = DateTime.Parse(DateTime.Now.ToString());
            db.tblContact.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index", "Default");
        }
        public PartialViewResult PartialMap()
        {
            return PartialView();
        }
        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }


    }
}