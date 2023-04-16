using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class CategoryController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.tblCategory.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddCategory()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddCategory(tblCategory p)
        {
            db.tblCategory.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteCategory(int id)
        {
            var values = db.tblCategory.Find(id);
            db.tblCategory.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateCategory(int id)
        {
            var values = db.tblCategory.Find(id);
            return View(values);
        }
        [HttpPost]
        public ActionResult UpdateCategory(tblCategory p)
        {
            var values = db.tblCategory.Find(p.CategoryID);
            values.CategoryName = p.CategoryName;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult GetMessageBySubject(int id)
        {
            var values = db.tblContact.Where(x => x.Subject == id).ToList();
            return View(values);
        }
    }
}