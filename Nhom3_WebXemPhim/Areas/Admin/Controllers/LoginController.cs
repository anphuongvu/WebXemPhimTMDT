using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Nhom3_WebXemPhim.Models;

namespace Nhom3_WebXemPhim.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        QLXemPhimEntities db = new QLXemPhimEntities();
        // GET: Admin/Login
        //public ActionResult Index()
        //{
        //    return View();
        //}
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
            var kh = db.TaiKhoans.SingleOrDefault(n => n.Username == sTaikhoan && n.Password == sMatkhau);

            if (kh != null)
            {
                //Session["name"] = kh.TenKhachHang;
                Session["Admin"] = kh;
                return RedirectToAction("Index", "Home", new {area = "Admin"});
            }
            else
            {
                ViewBag.ThongBao = "Tên tài khoản hoặc mật khẩu không đúng";
                return View();
            }


        }
        public ActionResult DangXuat()
        {
            Session.Clear();
            return RedirectToAction("DangNhap", "Login", new {area= "Admin"});
        }
    }
}