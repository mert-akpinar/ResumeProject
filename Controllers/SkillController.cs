using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;
namespace ResumeProject.Controllers
{
    public class SkillController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            var values = db.tblSkill.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult AddSkill()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSkill(tblSkill d)
        {
            db.tblSkill.Add(d);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        public ActionResult DeleteSkill(int id)
        {
            var value = db.tblSkill.Find(id);
            db.tblSkill.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult UpdateSkill(int id)
        {
            var value = db.tblSkill.Find(id);
            return View(value);

        }
        [HttpPost]

        public ActionResult UpdateSkill(tblSkill b)
        {
            var value = db.tblSkill.Find(b.SkillID);
            value.SkillTitle = b.SkillTitle;
            value.SkillIcon = b.SkillIcon;
            value.SkillDescription = b.SkillDescription;

            db.SaveChanges();
            return RedirectToAction("Index");



        }
    }


}