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
    public class DonMuaGoiPhimsController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/DonMuaGoiPhims
        public ActionResult Index()
        {
            var donMuaGoiPhims = db.DonMuaGoiPhims.Include(d => d.GoiPhim).Include(d => d.KhachHang).Include(d => d.TaiKhoan).Include(d => d.Voucher);
            return View(donMuaGoiPhims.ToList());
        }

        public ActionResult DonMuaSapHetHan()
        {
            var donMuaGoiPhims = db.DonMuaGoiPhims.Include(d => d.GoiPhim).Include(d => d.KhachHang).Include(d => d.TaiKhoan).Include(d => d.Voucher);
            return View(donMuaGoiPhims.ToList());
        }

        // GET: Admin/DonMuaGoiPhims/Details/5
        public ActionResult Details(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonMuaGoiPhim donMuaGoiPhim = db.DonMuaGoiPhims.Find(id);
            if (donMuaGoiPhim == null)
            {
                return HttpNotFound();
            }
            return View(donMuaGoiPhim);
        }

        // GET: Admin/DonMuaGoiPhims/Create
        public ActionResult Create()
        {
            ViewBag.MaGoiPhim = new SelectList(db.GoiPhims, "MaGoiPhim", "LoaiGoiPhim");
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang");
            ViewBag.MaTaiKhoan = new SelectList(db.TaiKhoans, "MaTaiKhoan", "Username");
            ViewBag.MaVoucher = new SelectList(db.Vouchers, "MaVoucher", "TenVoucher");
            return View();
        }

        // POST: Admin/DonMuaGoiPhims/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "MaDonMuaGoi,MaTaiKhoan,MaKhachHang,MaGoiPhim,ThoiGian,TongTien,TrangThai,MaVoucher")] DonMuaGoiPhim donMuaGoiPhim)
        {
            if (ModelState.IsValid)
            {
                db.DonMuaGoiPhims.Add(donMuaGoiPhim);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.MaGoiPhim = new SelectList(db.GoiPhims, "MaGoiPhim", "LoaiGoiPhim", donMuaGoiPhim.MaGoiPhim);
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donMuaGoiPhim.MaKhachHang);
            ViewBag.MaTaiKhoan = new SelectList(db.TaiKhoans, "MaTaiKhoan", "Username", donMuaGoiPhim.MaTaiKhoan);
            ViewBag.MaVoucher = new SelectList(db.Vouchers, "MaVoucher", "TenVoucher", donMuaGoiPhim.MaVoucher);
            return View(donMuaGoiPhim);
        }

        // GET: Admin/DonMuaGoiPhims/Edit/5
        public ActionResult Edit(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonMuaGoiPhim donMuaGoiPhim = db.DonMuaGoiPhims.Find(id);
            if (donMuaGoiPhim == null)
            {
                return HttpNotFound();
            }
            ViewBag.MaGoiPhim = new SelectList(db.GoiPhims, "MaGoiPhim", "LoaiGoiPhim", donMuaGoiPhim.MaGoiPhim);
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donMuaGoiPhim.MaKhachHang);
            ViewBag.MaTaiKhoan = new SelectList(db.TaiKhoans, "MaTaiKhoan", "Username", donMuaGoiPhim.MaTaiKhoan);
            ViewBag.MaVoucher = new SelectList(db.Vouchers, "MaVoucher", "TenVoucher", donMuaGoiPhim.MaVoucher);
            return View(donMuaGoiPhim);
        }

        // POST: Admin/DonMuaGoiPhims/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "MaDonMuaGoi,MaTaiKhoan,MaKhachHang,MaGoiPhim,ThoiGian,TongTien,TrangThai,MaVoucher")] DonMuaGoiPhim donMuaGoiPhim)
        {
            if (ModelState.IsValid)
            {
                db.Entry(donMuaGoiPhim).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.MaGoiPhim = new SelectList(db.GoiPhims, "MaGoiPhim", "LoaiGoiPhim", donMuaGoiPhim.MaGoiPhim);
            ViewBag.MaKhachHang = new SelectList(db.KhachHangs, "MaKhachHang", "TenKhachHang", donMuaGoiPhim.MaKhachHang);
            ViewBag.MaTaiKhoan = new SelectList(db.TaiKhoans, "MaTaiKhoan", "Username", donMuaGoiPhim.MaTaiKhoan);
            ViewBag.MaVoucher = new SelectList(db.Vouchers, "MaVoucher", "TenVoucher", donMuaGoiPhim.MaVoucher);
            return View(donMuaGoiPhim);
        }

        // GET: Admin/DonMuaGoiPhims/Delete/5
        public ActionResult Delete(short? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            DonMuaGoiPhim donMuaGoiPhim = db.DonMuaGoiPhims.Find(id);
            if (donMuaGoiPhim == null)
            {
                return HttpNotFound();
            }
            return View(donMuaGoiPhim);
        }

        // POST: Admin/DonMuaGoiPhims/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(short id)
        {
            DonMuaGoiPhim donMuaGoiPhim = db.DonMuaGoiPhims.Find(id);
            db.DonMuaGoiPhims.Remove(donMuaGoiPhim);
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
