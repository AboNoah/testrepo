using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteTemplete.Models;

namespace WebSiteTemplete.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Main()
        {

            ViewBag.TitleID = new SelectList(db.Titles, "ID", "TitleName", "TextTypeID");
            ViewBag.ParaGrapheID = new SelectList(db.ParaGraphes, "ID", "ParaGrapheName", "TextTypeID");


            return View(ViewBag);
        }
        public ActionResult MainSetting()
        {
            ViewBag.TitleID = new SelectList(db.Titles, "ID", "TitleName","TextTypeID");
            ViewBag.ParaGrapheID = new SelectList(db.ParaGraphes, "ID", "ParaGrapheName","TextTypeID");

            return View(ViewBag);
        }
        public ActionResult WarningPage()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult finance()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}