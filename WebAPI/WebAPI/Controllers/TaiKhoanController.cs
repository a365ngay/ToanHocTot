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
    public class TaiKhoanController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<TaiKhoan> item = TaiKhoanDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] TaiKhoan x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            TaiKhoanDAO.Instance.Create(x.Username, x.Password, x.IDUser, x.IDQuyen);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] TaiKhoan x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            TaiKhoanDAO.Instance.Update(x.Username, x.Password, x.IDUser, x.IDQuyen);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string Username)
        {
            if (Username == "" || Username == null)
                return BadRequest("Not a valid tai khoan");
            TaiKhoanDAO.Instance.Delete(Username);
            return Ok();
        }
    }
}
