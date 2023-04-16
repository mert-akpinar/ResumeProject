using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class ProjectController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var value = db.tblProject.ToList();
            return View(value);
        }
        public ActionResult DeleteProject(int id)
        {
            var valius = db.tblProject.Find(id);
            db.tblProject.Remove(valius);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult AddProject()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProject(tblProject a)
        {
            db.tblProject.Add(a);
            db.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var value = db.tblProject.Find(id);
            return View(value);
        }
        [HttpPost]
        public ActionResult UpdateProject(tblProject a)
        {
            var values = db.tblProject.Find(a.ProjectID);
            values.ProjectTitle = a.ProjectTitle;
            values.ProjectDescription = a.ProjectDescription;
            values.ProjectImgUrl = a.ProjectImgUrl;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}