using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class PhuHuynh
    {
        public string MaPH { get; set; }
        public string TenPH { get; set; }
        public string DiaChi { get; set; }
        public string SoDT { get; set; }
        public string MaHS { get; set; }

        public PhuHuynh(string MaPH, string TenPH, string DiaChi, string SoDT, string MaHS)
        {
            this.MaPH = MaPH;
            this.TenPH = TenPH;
            this.DiaChi = DiaChi;
            this.SoDT = SoDT;
            this.MaHS = MaHS;
        }

        public PhuHuynh(DataRow row)
        {
            this.MaPH = row["MaPH"].ToString();
            this.TenPH = row["TenPH"].ToString();
            this.DiaChi = row["DiaChi"].ToString();
            this.SoDT = row["SoDT"].ToString();
            this.MaHS = row["MaHS"].ToString();

        }

        public PhuHuynh()
        {

        }
    }
}
