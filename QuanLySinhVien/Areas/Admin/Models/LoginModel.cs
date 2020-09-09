using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLySinhVien.Areas.Admin.Models
{
    public class LoginModel
    {
       // [Required(ErrorMessage = "Mời nhập tài khoản")]
        public string TaiKhoan { set; get; }
       // [Required(ErrorMessage = "Mời nhập mật khẩu")]
        public string MatKhau { set; get; }

        public bool RememberMe { set; get; }
    }
}