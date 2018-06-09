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
    public class HocSinhController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<HocSinh> item = HocSinhDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] HocSinh x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            HocSinhDAO.Instance.Create(x.MaHS, x.TenHS, x.Lop, x.Truong, x.Loptt);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] HocSinh x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            HocSinhDAO.Instance.Update(x.MaHS, x.TenHS, x.Lop, x.Truong, x.Loptt);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaHS)
        {
            if (MaHS == "" || MaHS == null)
                return BadRequest("Not a valid hoc sinh");
            HocSinhDAO.Instance.Delete(MaHS);
            return Ok();
        }
    }
}
