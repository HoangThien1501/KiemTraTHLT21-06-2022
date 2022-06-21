namespace NguyenLyHoangThien_1911061454.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTiet")]
    public partial class ChiTiet
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int mahd { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(7)]
        public string malich { get; set; }

        public int? soluong { get; set; }

        public virtual HoaDon HoaDon { get; set; }

        public virtual LichChieu LichChieu { get; set; }
    }
}
