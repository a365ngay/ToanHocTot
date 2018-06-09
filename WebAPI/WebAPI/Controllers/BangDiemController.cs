using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPIData.DTO;
using WebAPIData.DAO;

namespace WebAPI.Controllers
{
    public class BangDiemController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<BangDiem> item = BangDiemDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] BangDiem x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            BangDiemDAO.Instance.Create(x.MaBangDiem, x.MaHS, x.Ngay, x.DiemHocTap, x.DiemYThuc);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] BangDiem x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            BangDiemDAO.Instance.Update(x.MaBangDiem, x.MaHS, x.Ngay, x.DiemHocTap, x.DiemYThuc);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaBangDiem)
        {
            if (MaBangDiem == "" || MaBangDiem == null)
                return BadRequest("Not a valid bang diem");
            BangDiemDAO.Instance.Delete(MaBangDiem);
            return Ok();
        }
    }
}
