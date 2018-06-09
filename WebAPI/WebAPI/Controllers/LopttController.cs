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
    public class LopttController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<Loptt> item = LopttDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] Loptt x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            LopttDAO.Instance.Create(x.MaLoptt, x.TenLoptt, x.MaGV, x.MaCS, x.MaTKB);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] Loptt x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            LopttDAO.Instance.Update(x.MaLoptt, x.TenLoptt, x.MaGV, x.MaCS, x.MaTKB);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaLoptt)
        {
            if (MaLoptt == "" || MaLoptt == null)
                return BadRequest("Not a valid lop trung tam");
            LopttDAO.Instance.Delete(MaLoptt);
            return Ok();
        }
    }
}
