namespace Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLySinhVienDbContext : DbContext
    {
        public QuanLySinhVienDbContext()
            : base("name=QuanLySinhVienDbContext")
        {
        }

        public virtual DbSet<DiemThi> DiemThis { get; set; }
        public virtual DbSet<GiangVien> GiangViens { get; set; }
        public virtual DbSet<HocPhan> HocPhans { get; set; }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Lop> Lops { get; set; }
        public virtual DbSet<SinhVien> SinhViens { get; set; }
        public virtual DbSet<ChiTietDiemThi> ChiTietDiemThis { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiemThi>()
                .HasOptional(e => e.HocPhan)
                .WithRequired(e => e.DiemThi);

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.MatKhau)
                .IsFixedLength();

            modelBuilder.Entity<GiangVien>()
                .Property(e => e.TaiKhoan)
                .IsFixedLength();

            modelBuilder.Entity<HocPhan>()
                .Property(e => e.TietBD)
                .IsFixedLength();

            modelBuilder.Entity<HocPhan>()
                .Property(e => e.SoTiet)
                .IsFixedLength();

            modelBuilder.Entity<HocPhan>()
                .Property(e => e.HocPhi)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Lop>()
                .HasMany(e => e.SinhViens)
                .WithRequired(e => e.Lop)
                .WillCascadeOnDelete(false);
        }
    }
}
