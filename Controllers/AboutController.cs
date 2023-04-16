using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class AboutController : Controller
    {
        DbResumeEntities db = new DbResumeEntities();
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialBanner()
        {
            return PartialView();
        }
        public PartialViewResult PartialAboutSection()
        {
            return PartialView();
        }
        public PartialViewResult PartialVideo()
        {
            return PartialView();
        }
        public PartialViewResult PartialContact()
        {
            return PartialView();
        }
        public PartialViewResult Partialreferance()
        {
            return PartialView();
        }
        public PartialViewResult PartialJs()
        {
            return PartialView();
        }

    }
}