namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDiemThi")]
    public partial class ChiTietDiemThi
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaSV { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaDT { get; set; }

        public int? DiemThiCuoiKi { get; set; }

        public int? DiemThucHanh { get; set; }

        public int? DiemLyThuyet { get; set; }

        public DateTime? NgayLap { get; set; }
    }
}
