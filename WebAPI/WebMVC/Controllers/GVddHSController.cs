using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;

namespace WebMVC.Controllers
{
    public class GVddHSController : Controller
    {
        ToanHocTotEntities db = new ToanHocTotEntities();
        // GET: NhanVien

        public ActionResult Index()
        {
            List<GVDiemDanhH> nv = (from n in db.GVDiemDanhHS select n).ToList();
            return View(nv);
        }
    }
}