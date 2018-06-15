using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Autherize(WebMVC.Models.TaiKhoan tkmodel)
        {
            using (ToanHocTotEntities db = new ToanHocTotEntities())
            {
                var userDetail = db.TaiKhoans.Where(x => x.Username == tkmodel.Username && x.Password == tkmodel.Password).FirstOrDefault();
                if(userDetail==null)
                {
                    tkmodel.LoginErrorMessage = "ban nhap sai tai khoan hoac mat khau";
                    return View("Index", tkmodel);
                }
                else
                {
                    Session["Username"] = userDetail.Username;
                    return RedirectToAction("Index", "Home");
                }
            }
                
        }
        public ActionResult LogOut()
        {
            string userName = Session["Username"].ToString();
            Session.Abandon();
            return RedirectToAction("Index", "Login");
        }
    }
}