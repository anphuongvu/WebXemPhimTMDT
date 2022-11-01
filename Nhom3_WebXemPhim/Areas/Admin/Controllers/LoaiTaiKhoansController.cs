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
    public class LoaiTaiKhoansController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/LoaiTaiKhoans
        public ActionResult Index()
        {
            return View(db.LoaiTaiKhoans.ToList());
        }

        // GET: Admin/LoaiTaiKhoans/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiTaiKhoan loaiTaiKhoan = db.LoaiTaiKhoans.Find(id);
            if (loaiTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(loaiTaiKhoan);
        }

        // GET: Admin/LoaiTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/LoaiTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaLoaiTK,TenLoaiTK")] LoaiTaiKhoan loaiTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.LoaiTaiKhoans.Add(loaiTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(loaiTaiKhoan);
        }

        // GET: Admin/LoaiTaiKhoans/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiTaiKhoan loaiTaiKhoan = db.LoaiTaiKhoans.Find(id);
            if (loaiTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(loaiTaiKhoan);
        }

        // POST: Admin/LoaiTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaLoaiTK,TenLoaiTK")] LoaiTaiKhoan loaiTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(loaiTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(loaiTaiKhoan);
        }

        // GET: Admin/LoaiTaiKhoans/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LoaiTaiKhoan loaiTaiKhoan = db.LoaiTaiKhoans.Find(id);
            if (loaiTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(loaiTaiKhoan);
        }

        // POST: Admin/LoaiTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            LoaiTaiKhoan loaiTaiKhoan = db.LoaiTaiKhoans.Find(id);
            db.LoaiTaiKhoans.Remove(loaiTaiKhoan);
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
    }
}
