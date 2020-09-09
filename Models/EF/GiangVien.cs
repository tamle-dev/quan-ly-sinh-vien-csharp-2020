namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GiangVien")]
    public partial class GiangVien
    {
        [Key]
        public long MaGV { get; set; }

        [StringLength(200)]
        public string TenGV { get; set; }

        [StringLength(10)]
        public string GioiTinh { get; set; }

        public DateTime? NgaySinh { get; set; }

        [StringLength(100)]
        public string NoiSinh { get; set; }

        public long? MaLop { get; set; }

        [StringLength(100)]
        public string Email { get; set; }

        [StringLength(50)]
        public string MatKhau { get; set; }

        [StringLength(50)]
        public string TaiKhoan { get; set; }

        public string GhiChu { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Column(TypeName = "xml")]
        public string MoreImage { get; set; }

        [StringLength(50)]
        public string TinhTrang { get; set; }

        public virtual Lop Lop { get; set; }
    }
}
