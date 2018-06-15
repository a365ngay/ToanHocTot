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
    [RoutePrefix("api/coso")]
    public class CoSoController : ApiController
    {
       
        [HttpGet]
        public IHttpActionResult Get()
        {
            List<CoSo> item = CoSoDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        [HttpPost]
        public IHttpActionResult Post([FromBody] CoSo x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            CoSoDAO.Instance.Create(x.MaCS, x.TenCS, x.DiaChi, x.MaNQL);
            return Ok();
        }

        [HttpPut]
        public IHttpActionResult Put([FromBody] CoSo x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            CoSoDAO.Instance.Update(x.MaCS, x.TenCS, x.DiaChi, x.MaNQL);
            return Ok();
        }


        [HttpDelete]
        [Route ("{MaCS}")]
        public IHttpActionResult Delete([FromUri] string MaCS)
        {
            if (MaCS == "" || MaCS == null)
                return BadRequest("Not a valid co so");
            CoSoDAO.Instance.Delete(MaCS);
            return Ok();
        }


        [HttpGet]
        [Route("{TenCS}")]
        public IHttpActionResult TimKiemCoSo([FromUri] string TenCS)
        {
            List<CoSo> item = CoSoDAO.Instance.TimKiemCoSo(TenCS);
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }
    }
}
