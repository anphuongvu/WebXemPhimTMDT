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
    public class TaiKhoansController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/TaiKhoans
        public ActionResult Index()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.LoaiTaiKhoan).Include(t => t.PhanQuyen);
            return View(taiKhoans.ToList());
        }

        // GET: Admin/TaiKhoans/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoan);
        }

        // GET: Admin/TaiKhoans/Create
        public ActionResult Create()
        {
            ViewBag.MaLoaiTK = new SelectList(db.LoaiTaiKhoans, "MaLoaiTK", "TenLoaiTK");
            ViewBag.MaPhanQuyen = new SelectList(db.PhanQuyens, "MaPhanQuyen", "TenPhanQuyen");
            return View();
        }

        // POST: Admin/TaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTaiKhoan,Username,Password,TrangThai,MaLoaiTK,MaPhanQuyen")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.TaiKhoans.Add(taiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaLoaiTK = new SelectList(db.LoaiTaiKhoans, "MaLoaiTK", "TenLoaiTK", taiKhoan.MaLoaiTK);
            ViewBag.MaPhanQuyen = new SelectList(db.PhanQuyens, "MaPhanQuyen", "TenPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: Admin/TaiKhoans/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaLoaiTK = new SelectList(db.LoaiTaiKhoans, "MaLoaiTK", "TenLoaiTK", taiKhoan.MaLoaiTK);
            ViewBag.MaPhanQuyen = new SelectList(db.PhanQuyens, "MaPhanQuyen", "TenPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // POST: Admin/TaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTaiKhoan,Username,Password,TrangThai,MaLoaiTK,MaPhanQuyen")] TaiKhoan taiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(taiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaLoaiTK = new SelectList(db.LoaiTaiKhoans, "MaLoaiTK", "TenLoaiTK", taiKhoan.MaLoaiTK);
            ViewBag.MaPhanQuyen = new SelectList(db.PhanQuyens, "MaPhanQuyen", "TenPhanQuyen", taiKhoan.MaPhanQuyen);
            return View(taiKhoan);
        }

        // GET: Admin/TaiKhoans/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            if (taiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(taiKhoan);
        }

        // POST: Admin/TaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            TaiKhoan taiKhoan = db.TaiKhoans.Find(id);
            db.TaiKhoans.Remove(taiKhoan);
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

        public ActionResult DuyetTaiKhoan()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.LoaiTaiKhoan).Include(t => t.PhanQuyen);
            return View(taiKhoans.ToList());
        }

        public ActionResult XoaTaiKhoan()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.LoaiTaiKhoan).Include(t => t.PhanQuyen);
            return View(taiKhoans.ToList());
        }

        public ActionResult CanhBaoTaiKhoan()
        {
            var taiKhoans = db.TaiKhoans.Include(t => t.LoaiTaiKhoan).Include(t => t.PhanQuyen);
            return View(taiKhoans.ToList());
        }
    }
}
