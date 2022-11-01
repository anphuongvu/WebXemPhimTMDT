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
    public class QuocGiasController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/QuocGias
        public ActionResult Index()
        {
            return View(db.QuocGias.ToList());
        }

        // GET: Admin/QuocGias/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuocGia quocGia = db.QuocGias.Find(id);
            if (quocGia == null)
            {
                return HttpNotFound();
            }
            return View(quocGia);
        }

        // GET: Admin/QuocGias/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/QuocGias/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaQuocGia,TenQuocGia")] QuocGia quocGia)
        {
            if (ModelState.IsValid)
            {
                db.QuocGias.Add(quocGia);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quocGia);
        }

        // GET: Admin/QuocGias/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuocGia quocGia = db.QuocGias.Find(id);
            if (quocGia == null)
            {
                return HttpNotFound();
            }
            return View(quocGia);
        }

        // POST: Admin/QuocGias/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaQuocGia,TenQuocGia")] QuocGia quocGia)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quocGia).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quocGia);
        }

        // GET: Admin/QuocGias/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuocGia quocGia = db.QuocGias.Find(id);
            if (quocGia == null)
            {
                return HttpNotFound();
            }
            return View(quocGia);
        }

        // POST: Admin/QuocGias/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            QuocGia quocGia = db.QuocGias.Find(id);
            db.QuocGias.Remove(quocGia);
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
