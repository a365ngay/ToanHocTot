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
    public class GVDiemDanhHSController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<GVDiemDanhHS> item = GVDiemDanhHSDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] GVDiemDanhHS x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            GVDiemDanhHSDAO.Instance.Create(x.IDDiemDanh, x.MaNV, x.Malop, x.NgayDD);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] GVDiemDanhHS x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            GVDiemDanhHSDAO.Instance.Update(x.IDDiemDanh, x.MaNV, x.Malop, x.NgayDD);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] int IDDiemDanh)
        {
            if (IDDiemDanh == 0)
                return BadRequest("Not a valid giao vien diem danh hoc sinh");
            GVDiemDanhHSDAO.Instance.Delete(IDDiemDanh);
            return Ok();
        }
    }
}
