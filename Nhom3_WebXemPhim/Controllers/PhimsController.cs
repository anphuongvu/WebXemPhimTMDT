using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom3_WebXemPhim.Models;

namespace Nhom3_WebXemPhim.Controllers
{
    public class PhimsController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Phims
        public ActionResult Index()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }

        // GET: Phims/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Phim phim = db.Phims.Find(id);
            if (phim == null)
            {
                return HttpNotFound();
            }

            phim.LuotXem += 1;
            db.Entry(phim).State = EntityState.Modified;
            db.SaveChanges();

            ViewBag.comments = db.BinhLuans.Where(cm => cm.MaPhim == id).ToList();
            ViewBag.phims = db.Phims.OrderByDescending(ph => ph.NamSanXuat).Take(3).ToList();
            return View(phim);
        }

        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
        public ActionResult PhimLe()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }

        public ActionResult PhimBo()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }

        public ActionResult PhimBanQuyen()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }
        public ActionResult PhimFree()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }

        [HttpPost]
        public ActionResult CreateComment([Bind(Include = "MaPhim,Ten,Email,NoiDungBinhLuan")] BinhLuan binhLuan)
        {
            if (ModelState.IsValid)
            {

                // set value
                binhLuan.ThoiGian = DateTime.Now;
                if (Session["user"] != null)
                {
                    binhLuan.MaTaiKhoan = (Session["user"] as TaiKhoan).MaTaiKhoan;
                }
                else
                {
                    // Bình luận ẩn danh
                }

                db.BinhLuans.Add(binhLuan);
                db.SaveChanges();
                return Redirect(Request.UrlReferrer.ToString());
            }
            return Redirect(Request.UrlReferrer.ToString());
        }
    }
}
