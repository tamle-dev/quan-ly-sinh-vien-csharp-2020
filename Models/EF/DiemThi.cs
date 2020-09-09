namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DiemThi")]
    public partial class DiemThi
    {
        public long? MaSV { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaHP { get; set; }

        public double? DiemLyThuyet { get; set; }

        public double? DiemThuHanh { get; set; }

        public double? DiemTrungBinh { get; set; }

        [Column("DiemThi")]
        public double? DiemThi1 { get; set; }

        public virtual SinhVien SinhVien { get; set; }

        public virtual HocPhan HocPhan { get; set; }
    }
}
