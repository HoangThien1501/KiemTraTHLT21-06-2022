namespace NguyenLyHoangThien_1911061454.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LichChieu")]
    public partial class LichChieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LichChieu()
        {
            ChiTiets = new HashSet<ChiTiet>();
        }

        [Key]
        [StringLength(7)]
        public string malich { get; set; }

        public int? maphim { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngay { get; set; }

        [StringLength(5)]
        public string gio { get; set; }

        public decimal? gia { get; set; }

        public int? soluong { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTiet> ChiTiets { get; set; }

        public virtual Phim Phim { get; set; }
    }
}
