using Models.DAO;
using QuanLySinhVien.Areas.Admin.Models;
using QuanLySinhVien.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace QuanLySinhVien.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View("Login");
        }

        public ActionResult Login(LoginModel model)
        {
            if(ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(model.TaiKhoan, model.MatKhau);
                // Nếu đăng nhập thành công, gán session
                if (result) 
                {
                    var user = dao.GetByID(model.TaiKhoan);
                    var userSession = new UserLogin();
                    userSession.TenGiaoVien = user.TenGV; 
                    userSession.MaGiaoVien = user.MaGV;
                    
                    Session.Add(CommonConstants.USER_SESSION,userSession);
                    return RedirectToAction("Index", "Home"); 
                }
                else
                {
                    ModelState.AddModelError("", "Đăng nhập thất bại, vui lòng thử lại");
                }
            }
            return View("Index");
        }
    }
}