using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class ThoiKhoaBieuController : Controller
    {
        ToanHocTotEntities db = new ToanHocTotEntities();
        // GET: NhanVien

        public ActionResult Index()
        {
            List<ThoiKhoaBieu> nv = (from n in db.ThoiKhoaBieux select n).ToList();
            return View(nv);
        }
    }
}