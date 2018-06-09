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
    public class ChiTietDDController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<ChiTietDD> item = ChiTietDDDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] ChiTietDD x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            ChiTietDDDAO.Instance.Create(x.IDDiemDanh, x.MaHS, x.TinhTrangDD, x.GhiChu);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] ChiTietDD x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            ChiTietDDDAO.Instance.Update(x.IDDiemDanh, x.MaHS, x.TinhTrangDD, x.GhiChu);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int IDDiemDanh)
        {
            if (IDDiemDanh == 0 )
                return BadRequest("Not a valid chi tiet diem danh");
            ChiTietDDDAO.Instance.Delete(IDDiemDanh);
            return Ok();
        }
    }
}
