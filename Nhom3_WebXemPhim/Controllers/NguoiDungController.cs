using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom3_WebXemPhim.Models;

namespace Nhom3_WebXemPhim.Controllers
{
    public class NguoiDungController : Controller
    {
        QLXemPhimEntities db = new QLXemPhimEntities();
        // GET: NguoiDung
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult DangKy()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(KhachHang kh)
        {
            if (ModelState.IsValid)
            {
                List<TaiKhoan> taiKhoans = db.TaiKhoans.Where(n => n.Username.Contains(kh.TaiKhoan.Username)).ToList();
                if (taiKhoans.Count != 0)
                {
                    //Nếu tên tài khaonr đã tồn tại
                    Response.Write("<script>alert('Tài khoản đã tồn tại!!!');</script>");
                    return View();
                }
                else
                {
                    TaiKhoan taiKhoan = new TaiKhoan(kh.TaiKhoan.MaTaiKhoan, kh.TaiKhoan.Username, kh.TaiKhoan.Password);
                    taiKhoans.Add(taiKhoan);
                    db.TaiKhoans.Add(taiKhoan);
                    //Luu vao csdl
                    db.SaveChanges();
                    if (db.TaiKhoans.Where(n => n.Username.Contains(kh.TaiKhoan.Username)).ToList().Count != 0)
                    {
                        List<KhachHang> khachHangs = db.KhachHangs.Where(n => n.TenKhachHang.Contains(kh.TenKhachHang)).ToList();
                        if (khachHangs.Count == 0)
                        {
                            kh.MaTaiKhoan = taiKhoans.Find(n => n.Username == kh.TaiKhoan.Username).MaTaiKhoan;
                            // Chen du lieu vao bang khach hang
                            db.KhachHangs.Add(kh);
                            //Luu vao csdl
                            db.SaveChanges();
                            TempData["message"] = "Đăng ký thành công!!";
                            return RedirectToAction("DangNhap", "NguoiDung");
                        }
                        else
                        {
                            Response.Write("<script>alert('Đăng ký thất bại!!!');</script>");
                        }
                    }

                }


            }
            return View();
        }
        [HttpGet]
        public ActionResult DangNhap()
        {

            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection f)
        {
            string sTaikhoan = f["txtTaiKhoan"].ToString();
            string sMatkhau = f.Get("txtMatKhau").ToString();
            var kh = db.KhachHangs.SingleOrDefault(n => n.TaiKhoan.Username == sTaikhoan && n.TaiKhoan.Password == sMatkhau);

            if (kh != null)
            {
                Session["name"] = kh.TenKhachHang;
                Session["TaiKhoan"] = kh;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng";
                return View();
            }


        }
    }
}