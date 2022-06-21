using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NguyenLyHoangThien_1911061454.Models
{
    public class Giohang
    {

        public class GioHang
        {
            DataContext data = new DataContext();
            [Display(Name = "Mã lịch chiếu")] public string malich { get; set; }
            [Display(Name = "Mã phim")] public int maphim { get; set; }
            [Display(Name = "Giá bán")] public double gia { get; set; }
            [Display(Name = "Số lượng")] public int iSoluong { get; set; }
            [Display(Name = "Thành tiền")]
            public Double dThanhtien
            {
                get { return iSoluong * gia; }
            }
            public GioHang(string id)
            {
                malich = id;
                LichChieu lich = data.LichChieux.Single(n => n.malich == malich);
                gia = double.Parse(lich.gia.ToString());
                iSoluong = 1;
            }
        }
    }
}