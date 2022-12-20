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
    public class GoiPhimsController : Controller
    {
        private QLXemPhimEntities db = new QLXemPhimEntities();

        // GET: Admin/GoiPhims
        public ActionResult Index()
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


        [HttpPost]
        public ActionResult ThanhToan(short MaGoiPhim, short MaTaiKhoan, double tongtien)
        {
            if (ModelState.IsValid)
            {
                DonMuaGoiPhim don = new DonMuaGoiPhim()
                {
                    MaGoiPhim = MaGoiPhim,
                    MaTaiKhoan = MaTaiKhoan,
                    TongTien = (decimal?)tongtien,
                    ThoiGian = DateTime.Now,
                    TrangThai = true
                };
                db.DonMuaGoiPhims.Add(don);
                db.SaveChanges();
                return Redirect("/Home");
            }

            return Redirect("/Home");
        }
    }
}
