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
    public class TrailersController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/Trailers
        public ActionResult Index()
        {
            var trailers = db.Trailers.Include(t => t.Phim);
            return View(trailers.ToList());
        }

        // GET: Admin/Trailers/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trailer trailer = db.Trailers.Find(id);
            if (trailer == null)
            {
                return HttpNotFound();
            }
            return View(trailer);
        }

        // GET: Admin/Trailers/Create
        public ActionResult Create()
        {
            ViewBag.MaPhim = new SelectList(db.Phims, "MaPhim", "TenPhim");
            return View();
        }

        // POST: Admin/Trailers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaTrailer,TenTrailer,HinhAnh,DuongDanURL,MaPhim")] Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                db.Trailers.Add(trailer);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaPhim = new SelectList(db.Phims, "MaPhim", "TenPhim", trailer.MaPhim);
            return View(trailer);
        }

        // GET: Admin/Trailers/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trailer trailer = db.Trailers.Find(id);
            if (trailer == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaPhim = new SelectList(db.Phims, "MaPhim", "TenPhim", trailer.MaPhim);
            return View(trailer);
        }

        // POST: Admin/Trailers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaTrailer,TenTrailer,HinhAnh,DuongDanURL,MaPhim")] Trailer trailer)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trailer).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaPhim = new SelectList(db.Phims, "MaPhim", "TenPhim", trailer.MaPhim);
            return View(trailer);
        }

        // GET: Admin/Trailers/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trailer trailer = db.Trailers.Find(id);
            if (trailer == null)
            {
                return HttpNotFound();
            }
            return View(trailer);
        }

        // POST: Admin/Trailers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            Trailer trailer = db.Trailers.Find(id);
            db.Trailers.Remove(trailer);
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
