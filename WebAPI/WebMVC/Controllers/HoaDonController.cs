using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class HoaDonController : Controller
    {
        ToanHocTotEntities db = new ToanHocTotEntities();
        // GET: NhanVien

        public ActionResult Index()
        {
            List<HoaDon> nv = (from n in db.HoaDons select n).ToList();
            return View(nv);
        }
    }
}