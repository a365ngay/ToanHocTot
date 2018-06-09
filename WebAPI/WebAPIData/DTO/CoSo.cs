using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class CoSo
    {
        public string MaCS { get; set; }
        public string TenCS { get; set; }
        public string DiaChi { get; set; }
        public string MaNQL { get; set; }

        public CoSo(string MaCS, string TenCS, string DiaChi, string MaNQL)
        {
            this.MaCS = MaCS;
            this.TenCS = TenCS;
            this.DiaChi = DiaChi;
            this.MaNQL = MaNQL;
        }

        public CoSo(DataRow row)
        {
            this.MaCS = row["MaCS"].ToString();
            this.TenCS = row["TenCS"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.MaNQL = row["MaNQL"].ToString();

        }

        public CoSo()
        {

        }
    }
}
