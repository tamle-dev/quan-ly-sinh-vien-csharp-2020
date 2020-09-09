namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("HocPhan")]
    public partial class HocPhan
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public long MaHP { get; set; }

        [StringLength(100)]
        public string TenHP { get; set; }

        [StringLength(10)]
        public string TietBD { get; set; }

        [StringLength(10)]
        public string SoTiet { get; set; }

        [Column(TypeName = "money")]
        public decimal? HocPhi { get; set; }

        public virtual DiemThi DiemThi { get; set; }
    }
}
