using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace QuanLySinhVien
{
    [Serializable]          // Class user login sẽ không được kế thừa
    public class UserLogin
    {
        // Lấy mã Giảng viên
        public long MaGiaoVien { set; get; }
        // Lấy tên Giảng viên
        public string TenGiaoVien { set; get; }
    }
}