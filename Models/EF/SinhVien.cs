namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SinhVien()
        {
            DiemThis = new HashSet<DiemThi>();
        }

        [Key]
        public long MaSV { get; set; }

        [StringLength(100)]
        public string TenSV { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        public string GhiChu { get; set; }

        [StringLength(200)]
        public string NoiSinh { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        public double? XepLoai { get; set; }

        [StringLength(200)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        [StringLength(100)]
        public string TrangThai { get; set; }

        public long MaLop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DiemThi> DiemThis { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
