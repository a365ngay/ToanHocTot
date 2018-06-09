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
    public class NhanVienController : ApiController
    {
        public IHttpActionResult Get()
        {
            List<NhanVien> item = NhanVienDAO.Instance.GetList();
            if (item.Count == 0)
            {
                return NotFound();
            }
            return Ok(item);
        }

        public IHttpActionResult Post([FromBody] NhanVien x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid model");

            NhanVienDAO.Instance.Create(x.MaNV, x.TenNV, x.GioiTinh, x.DiaChi, x.SoDT, x.ChucVu, x.Luong, x.MaCS);
            return Ok();
        }

        public IHttpActionResult Put([FromBody] NhanVien x)
        {
            if (!ModelState.IsValid)
                return BadRequest("Not a valid data");
            NhanVienDAO.Instance.Update(x.MaNV, x.TenNV, x.GioiTinh, x.DiaChi, x.SoDT, x.ChucVu, x.Luong, x.MaCS);
            return Ok();
        }

        public IHttpActionResult Delete([FromUri] string MaNV)
        {
            if (MaNV == "" || MaNV == null)
                return BadRequest("Not a valid nhan vien");
            NhanVienDAO.Instance.Delete(MaNV);
            return Ok();
        }
    }
}
