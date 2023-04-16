using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace ResumeProject.Controllers
{
    public class StatisticController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        // GET: Statistic
        public ActionResult Index()
        {
            ViewBag.SkillCount = db.tblSkill.Count();
            ViewBag.TechnologyCount = db.tblTechnology.Count();
            ViewBag.cSharpValue = db.tblTechnology.Where(x => x.TechnologyTitle == "C#").Select(y => y.TechnologyValue).FirstOrDefault();
            ViewBag.ContactCount = db.tblContact.Count();
            ViewBag.SubjectTesekkur = db.tblContact.Where(x => x.Subject == 1).Count();
            ViewBag.SumTechnologyValue = db.tblTechnology.Sum(x => x.TechnologyValue);
            ViewBag.avarageTechnologyValue = db.tblTechnology.Average(x => x.TechnologyValue);
            ViewBag.GetBy3ID = db.tblSkill.Where(x=>x.SkillID == 3).Select(y => y.SkillTitle).FirstOrDefault();
            ViewBag.maxTechnologyValue = db.tblTechnology.Max(x => x.TechnologyValue);
            return View();
        }
    }
}