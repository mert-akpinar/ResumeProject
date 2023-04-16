using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class TechnologyController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.tblTechnology.ToList();

            return View(values);
        }
        [HttpGet]
        public ActionResult AddTechnology()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddTechnology(tblTechnology D)
        {
            db.tblTechnology.Add(D);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteTechnology(int id)
        {
            var value = db.tblTechnology.Find(id);
            db.tblTechnology.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateTechnology(int id)
        {

            var value = db.tblTechnology.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateTechnology(tblTechnology P)
        {

            var value = db.tblTechnology.Find(P.TechnologyID);
            value.TechnologyTitle = P.TechnologyTitle;
            value.TechnologyValue = P.TechnologyValue;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}