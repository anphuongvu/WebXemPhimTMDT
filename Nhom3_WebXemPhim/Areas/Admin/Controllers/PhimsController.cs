using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Nhom3_WebXemPhim.Models;

namespace Nhom3_WebXemPhim.Areas.Admin.Controllers
{
    public class PhimsController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/Phims
        public ActionResult Index()
        {
            var phims = db.Phims.Include(p => p.BanQuyenPhim).Include(p => p.QuocGia).Include(p => p.TheLoai).Include(p => p.Trailer);
            return View(phims.ToList());
        }

        // GET: Admin/Phims/Details/5
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
            return View(phim);
        }

        // GET: Admin/Phims/Create
        public ActionResult Create()
        {
            ViewBag.MaHopDong = new SelectList(db.BanQuyenPhims, "MaHopDong", "ChiTietHopDong");
            ViewBag.MaQuocGia = new SelectList(db.QuocGias, "MaQuocGia", "TenQuocGia");
            ViewBag.MaTheLoai = new SelectList(db.TheLoais, "MaTheLoai", "TenTheLoai");
            ViewBag.MaTrailer = new SelectList(db.Trailers, "MaTrailer", "TenTrailer");
            return View();
        }

        // POST: Admin/Phims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaPhim,MaTheLoai,MaTrailer,MaHopDong,TenPhim,TenDienVien,HinhAnhPhim,MoTaPhim,ThoiLuongPhim,NamSanXuat,MaQuocGia,LuotXem,DuongDanURL,DonGia")] Phim phim)
        {
            if (ModelState.IsValid)
            {
                db.Phims.Add(phim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaHopDong = new SelectList(db.BanQuyenPhims, "MaHopDong", "ChiTietHopDong", phim.MaHopDong);
            ViewBag.MaQuocGia = new SelectList(db.QuocGias, "MaQuocGia", "TenQuocGia", phim.MaQuocGia);
            ViewBag.MaTheLoai = new SelectList(db.TheLoais, "MaTheLoai", "TenTheLoai", phim.MaTheLoai);
            ViewBag.MaTrailer = new SelectList(db.Trailers, "MaTrailer", "TenTrailer", phim.MaTrailer);
            return View(phim);
        }

        // GET: Admin/Phims/Edit/5
        public ActionResult Edit(short? id)
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
            ViewBag.MaHopDong = new SelectList(db.BanQuyenPhims, "MaHopDong", "ChiTietHopDong", phim.MaHopDong);
            ViewBag.MaQuocGia = new SelectList(db.QuocGias, "MaQuocGia", "TenQuocGia", phim.MaQuocGia);
            ViewBag.MaTheLoai = new SelectList(db.TheLoais, "MaTheLoai", "TenTheLoai", phim.MaTheLoai);
            ViewBag.MaTrailer = new SelectList(db.Trailers, "MaTrailer", "TenTrailer", phim.MaTrailer);
            return View(phim);
        }

        // POST: Admin/Phims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaPhim,MaTheLoai,MaTrailer,MaHopDong,TenPhim,TenDienVien,HinhAnhPhim,MoTaPhim,ThoiLuongPhim,NamSanXuat,MaQuocGia,LuotXem,DuongDanURL,DonGia")] Phim phim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(phim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaHopDong = new SelectList(db.BanQuyenPhims, "MaHopDong", "ChiTietHopDong", phim.MaHopDong);
            ViewBag.MaQuocGia = new SelectList(db.QuocGias, "MaQuocGia", "TenQuocGia", phim.MaQuocGia);
            ViewBag.MaTheLoai = new SelectList(db.TheLoais, "MaTheLoai", "TenTheLoai", phim.MaTheLoai);
            ViewBag.MaTrailer = new SelectList(db.Trailers, "MaTrailer", "TenTrailer", phim.MaTrailer);
            return View(phim);
        }

        // GET: Admin/Phims/Delete/5
        public ActionResult Delete(short? id)
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
            return View(phim);
        }

        // POST: Admin/Phims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Phim phim = db.Phims.Find(id);
            db.Phims.Remove(phim);
            db.SaveChanges();
            return RedirectToAction("Index");
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
    }
}
