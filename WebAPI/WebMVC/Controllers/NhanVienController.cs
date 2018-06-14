using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        ToanHocTotEntities db = new ToanHocTotEntities();
        // GET: NhanVien

        public ActionResult Index()
        {
            List<NhanVien> nv = (from n in db.NhanViens select n).ToList();
            return View(nv);
        }
    }
}