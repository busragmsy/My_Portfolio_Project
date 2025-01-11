using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaPortfolyo.Models;

namespace AcunMedyaPortfolyo.Controllers
{
    public class AboutController : Controller
    {
        DbDominicPortfolioEntities db = new DbDominicPortfolioEntities();
        public ActionResult AboutList()
        {
            var values = db.TblAbout.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult CreateAbout()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateAbout(TblAbout p)
        {
            db.TblAbout.Add(p);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        public ActionResult DeleteAbout(int id)
        {
            var values = db.TblAbout.Find(id);
            db.TblAbout.Remove(values);
            db.SaveChanges();
            return RedirectToAction("AboutList");
        }
        
        public ActionResult DownloadPDF()
        {
            string filePath = Server.MapPath("/Templates/Busra_gumusay_cv.pdf");
            string fileName = "Busra_gumusay_cv.pdf";


            return File(filePath, "application/pdf", fileName);
        }
    }
}