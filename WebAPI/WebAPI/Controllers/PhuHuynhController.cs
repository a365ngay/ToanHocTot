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
    public class PhuHuynhController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<PhuHuynh> item = PhuHuynhDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] PhuHuynh x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            PhuHuynhDAO.Instance.Create(x.MaPH, x.TenPH, x.DiaChi, x.SoDT, x.MaHS);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] PhuHuynh x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            PhuHuynhDAO.Instance.Update(x.MaPH, x.TenPH, x.DiaChi, x.SoDT, x.MaHS);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaPH)
        {
            if (MaPH == "" || MaPH == null)
                return BadRequest("Not a valid phu huynh");
            PhuHuynhDAO.Instance.Delete(MaPH);
            return Ok();
        }
    }
}
