using Nhom3_WebXemPhim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhom3_WebXemPhim.Controllers
{
    public class HomeController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PhimMoi()
        {
            List<Phim> phims = db.Phims.OrderByDescending(ph => ph.NamSanXuat).Take(10).ToList();

            ViewBag.phims = db.Phims.OrderByDescending(ph => ph.NamSanXuat).Take(3).ToList(); ;
            return View(phims);
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
    }
}