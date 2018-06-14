using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebMVC.Models;
using System.Web.Helpers;
using System.Collections;

namespace WebMVC.Controllers
{
    public class BangDiemController : Controller
    {
        ToanHocTotEntities db = new ToanHocTotEntities();
        // GET: BangDiem
        public ActionResult Index()
        {
            List<BangDiem> nv = (from n in db.BangDiems select n).ToList();
            return View(nv);
        }

        public ActionResult CharterColum()
        {
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from a in db.BangDiems select a);
            results.ToList().ForEach(rs => xValue.Add(rs.Ngay));
            results.ToList().ForEach(rs => yValue.Add(rs.DiemHocTap));

            new Chart(width: 550, height: 300, theme: ChartTheme.Green)
                .AddTitle("BIỂU ĐỒ QUÁ TRÌNH HỌC TẬP")
                .AddSeries("", chartType: "Column", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }

        public ActionResult CharterColum1()
        {
            ArrayList xValue = new ArrayList();
            ArrayList yValue = new ArrayList();

            var results = (from a in db.BangDiems select a);
            results.ToList().ForEach(rs => xValue.Add(rs.Ngay));
            results.ToList().ForEach(rs => yValue.Add(rs.DiemYThuc));

            new Chart(width: 550, height: 300, theme: ChartTheme.Yellow)
                .AddTitle("BIỂU ĐỒ RÈN LUYỆN Ý THỨC HỌC TẬP")
                .AddSeries("", chartType: "Column", xValue: xValue, yValues: yValue)
                .Write("bmp");

            return null;
        }
    }
}