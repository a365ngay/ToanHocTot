using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPIData.DTO;

namespace WebServer.Controllers
{
    public class NhanVienController : Controller
    {
        // GET: NhanVien
        public ActionResult Index()
        {
            IEnumerable<NhanVien> nvList;
            HttpResponseMessage respone = GlobalVariables.WebApiClient.GetAsync("NhanVien").Result;
            nvList = respone.Content.ReadAsAsync<IEnumerable<NhanVien>>().Result;
            return View(nvList);
        }
    }
}