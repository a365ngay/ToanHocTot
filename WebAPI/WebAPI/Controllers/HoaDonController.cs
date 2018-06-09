using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIData.DAO;
using WebAPIData.DTO;

namespace WebAPI.Controllers
{
    public class HoaDonController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<HoaDon> item = HoaDonDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] HoaDon x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            HoaDonDAO.Instance.Create(x.MaHD, x.Ngay, x.MaHS, x.MaNV, x.SoTien, x.GhiChu);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] HoaDon x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            HoaDonDAO.Instance.Update(x.MaHD, x.Ngay, x.MaHS, x.MaNV, x.SoTien, x.GhiChu);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaHD)
        {
            if (MaHD == "" || MaHD == null)
                return BadRequest("Not a valid hoa don");
            HoaDonDAO.Instance.Delete(MaHD);
            return Ok();
        }
    }
}
