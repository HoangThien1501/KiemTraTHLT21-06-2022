using NguyenLyHoangThien_1911061454.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenLyHoangThien_1911061454.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        DataContext context = new DataContext();
        string name;
        // GET: Account
        public ActionResult DangKy()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DangKy(FormCollection collection)
        {
            KhachHang kh = new KhachHang();
            kh.hoten = collection["hoten"];
            
                kh.matkhau = collection["matkhau"];
            
            kh.diachi = collection["diachi"];
            kh.dienthoai = collection["dienthoai"];
            
            context.KhachHangs.Add(kh);
            context.SaveChanges();
            TempData["msgss"] = "<script>alert('Đăng ký thành công!');</script>";
            return RedirectToAction("DangNhap", "Account");
        }

        public ActionResult DangNhap()
        {
            return View();
        }
        [HttpPost]
        public ActionResult DangNhap(FormCollection collection)
        {
            string userN = collection["hoten"];
            name = collection["hoten"];
            string passW = collection["matkhau"];
            KhachHang kh = context.KhachHangs.FirstOrDefault(p => p.hoten == userN);
            if (kh == null)
            {
                return Content("<script>alert('Tài khoản không tồn tại!'); window.location.href='/Account/DangNhap';</script>");
            }
            else
            {
                if (kh.matkhau != passW)
                {
                    return Content("<script>alert('Mật khẩu không chính xác!'); window.location.href='/Account/DangNhap';</script>");
                }
                else
                {
                    Session["UserN"] = userN;
                    ViewBag.User = name;
                    return Content("<script>alert('Đăng nhập thành công!'); window.location.href='/Home/Index';</script>");
                }
            }
        }
        public ActionResult DangNhapPartial()
        {
            return PartialView();
        }
    }
}