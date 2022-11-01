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
    public class DienViensController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/DienViens
        public ActionResult Index()
        {
            return View(db.DienViens.ToList());
        }

        // GET: Admin/DienViens/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienVien dienVien = db.DienViens.Find(id);
            if (dienVien == null)
            {
                return HttpNotFound();
            }
            return View(dienVien);
        }

        // GET: Admin/DienViens/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/DienViens/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDienVien,TenDienVien,ThongTin")] DienVien dienVien)
        {
            if (ModelState.IsValid)
            {
                db.DienViens.Add(dienVien);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(dienVien);
        }

        // GET: Admin/DienViens/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienVien dienVien = db.DienViens.Find(id);
            if (dienVien == null)
            {
                return HttpNotFound();
            }
            return View(dienVien);
        }

        // POST: Admin/DienViens/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDienVien,TenDienVien,ThongTin")] DienVien dienVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(dienVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dienVien);
        }

        // GET: Admin/DienViens/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DienVien dienVien = db.DienViens.Find(id);
            if (dienVien == null)
            {
                return HttpNotFound();
            }
            return View(dienVien);
        }

        // POST: Admin/DienViens/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            DienVien dienVien = db.DienViens.Find(id);
            db.DienViens.Remove(dienVien);
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
