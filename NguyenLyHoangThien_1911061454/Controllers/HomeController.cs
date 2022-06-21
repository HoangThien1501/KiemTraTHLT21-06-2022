using NguyenLyHoangThien_1911061454.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NguyenLyHoangThien_1911061454.Controllers
{
    public class HomeController : Controller
    {
        DataContext dt = new DataContext();
        public ActionResult Index()
        {
            var all_phim = from s in dt.Phims select s;
            return View(all_phim);
            
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult LichChieu()
        {
            var lichChieus = from s in dt.LichChieux select s;
            return View(lichChieus);
        }
        public ActionResult PhimDangChieu()
        {
            var lichChieus = from s in dt.LichChieux select s;
            return View(lichChieus);
        }
    }
}