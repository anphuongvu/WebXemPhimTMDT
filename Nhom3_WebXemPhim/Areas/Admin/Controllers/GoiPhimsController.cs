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
    public class GoiPhimsController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/GoiPhims
        public ActionResult Index()
        {
            return View(db.GoiPhims.ToList());
        }

        // GET: Admin/GoiPhims
        public ActionResult DanhSachGoi()
        {
            return View(db.GoiPhims.ToList());
        }

        // GET: Admin/GoiPhims/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoiPhim goiPhim = db.GoiPhims.Find(id);
            if (goiPhim == null)
            {
                return HttpNotFound();
            }
            return View(goiPhim);
        }

        // GET: Admin/GoiPhims/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/GoiPhims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaGoiPhim,LoaiGoiPhim,DonGia")] GoiPhim goiPhim)
        {
            if (ModelState.IsValid)
            {
                db.GoiPhims.Add(goiPhim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(goiPhim);
        }

        // GET: Admin/GoiPhims/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoiPhim goiPhim = db.GoiPhims.Find(id);
            if (goiPhim == null)
            {
                return HttpNotFound();
            }
            return View(goiPhim);
        }

        // POST: Admin/GoiPhims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaGoiPhim,LoaiGoiPhim,DonGia")] GoiPhim goiPhim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(goiPhim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(goiPhim);
        }

        // GET: Admin/GoiPhims/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GoiPhim goiPhim = db.GoiPhims.Find(id);
            if (goiPhim == null)
            {
                return HttpNotFound();
            }
            return View(goiPhim);
        }

        // POST: Admin/GoiPhims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            GoiPhim goiPhim = db.GoiPhims.Find(id);
            db.GoiPhims.Remove(goiPhim);
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
