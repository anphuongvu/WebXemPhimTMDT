using Nhom3_WebXemPhim.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nhom3_WebXemPhim.Areas.Admin.Controllers
{
    public class SearchController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        [HttpPost]
        public ActionResult TimKiem(string searchValue)
        {

            List<Phim> phims = db.Phims.Where(ph => ph.TenPhim.Contains(searchValue) || ph.TenDienVien.Contains(searchValue)).OrderByDescending(ph => ph.NamSanXuat).Take(10).ToList();

            return View(phims);
        }
    }
}