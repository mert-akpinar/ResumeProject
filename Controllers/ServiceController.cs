using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class ServiceController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var value = db.tblService.ToList();
            return View(value);
        }
        public ActionResult DeleteService(int id)
        {
            var value = db.tblService.Find(id);
            db.tblService.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddService()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddService(tblService p)
        {
            db.tblService.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateService(int id)
        {
            var value = db.tblService.Find(id);
            return View(value);

        }
        [HttpPost]
        public ActionResult UpdateService(tblService b)
        {
            var value = db.tblService.Find(b.ServiceID);
            value.ServiceTitle = b.ServiceTitle;
            value.ServiceIcon = b.ServiceIcon;
            value.ServiceDescription = b.ServiceDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}