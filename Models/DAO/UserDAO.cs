using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.DAO
{
    public class UserDAO
    {
        QuanLySinhVienDbContext db = new QuanLySinhVienDbContext();

        // Constructor
        // Khi khởi tạo UserDao thì khởi tạo một đối tượng db ( QuanLySinhVienDbContext )
        public UserDAO()
        {
            db = new QuanLySinhVienDbContext();
        }

        public long Insert(GiangVien giangVien)
        {
            db.GiangViens.Add(giangVien);
            db.SaveChanges();
            return giangVien.MaGV;
        }

        public GiangVien GetByID(string taiKhoan)
        {
            return db.GiangViens.SingleOrDefault(x => x.TaiKhoan == taiKhoan);
        }

        public bool Login(string taiKhoan, string matKhau)
        {
            var result = db.GiangViens.Count(x => x.TaiKhoan == taiKhoan && x.MatKhau == matKhau);

            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
                
        }
    }
}
