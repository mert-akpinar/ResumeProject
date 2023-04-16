using ResumeProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ResumeProject.Controllers
{
    public class MyProjectController : Controller
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
        public PartialViewResult PartialSection() 
        {
            var value = db.tblService.ToList();
            return PartialView(value);
        }
        public PartialViewResult PartialProject() 
        {
            return PartialView();
        }
    }
}