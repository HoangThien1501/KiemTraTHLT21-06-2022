namespace NguyenLyHoangThien_1911061454.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Phim")]
    public partial class Phim
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Phim()
        {
            LichChieux = new HashSet<LichChieu>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maphim { get; set; }

        [StringLength(30)]
        public string tenphim { get; set; }

        [StringLength(30)]
        public string daodien { get; set; }

        [StringLength(50)]
        public string hinh { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ngaychieu { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LichChieu> LichChieux { get; set; }
    }
}
