using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ResumeProject.Models;

namespace ResumeProject.Controllers
{
    public class DefaultController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            return PartialView();
        }

        public PartialViewResult PartialHeader()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavBar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            return PartialView();
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.tblProfile.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.tblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTech()
        {
            var values = db.tblTechnology.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialCounter()
        {
            ViewBag.skillcount = db.tblSkill.Count();
            ViewBag.servicecount = db.tblService.Count();
            ViewBag.avgtechvalue = db.tblTechnology.Average(x => x.TechnologyValue);
            ViewBag.happycustomer = 38;
            return PartialView();
        }

        public PartialViewResult PartialProjects()
        {
            var values = db.tblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialBrands()
        {

            return PartialView();
        }

        public PartialViewResult PartialFooter()
        {
            var values = db.tblProfile.ToList();
            return PartialView(values);
        }
        public PartialViewResult PartialScripts()
        {

            return PartialView();
        }

    }
}