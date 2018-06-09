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
    public class ThoiKhoaBieuController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<ThoiKhoaBieu> item = ThoiKhoaBieuDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] ThoiKhoaBieu x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            ThoiKhoaBieuDAO.Instance.Create(x.MaTKB, x.NgayHoc, x.ThoiGianHoc);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] ThoiKhoaBieu x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            ThoiKhoaBieuDAO.Instance.Update(x.MaTKB, x.NgayHoc, x.ThoiGianHoc);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaTKB)
        {
            if (MaTKB == "" || MaTKB == null)
                return BadRequest("Not a valid thoi khoa bieu");
            ThoiKhoaBieuDAO.Instance.Delete(MaTKB);
            return Ok();
        }
    }
}
