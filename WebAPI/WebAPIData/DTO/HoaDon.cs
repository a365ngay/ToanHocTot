using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class HoaDon
    {
        public string MaHD { get; set; }
        public string Ngay { get; set; }
        public string MaHS { get; set; }
        public string MaNV { get; set; }
        public int SoTien { get; set; }
        public string GhiChu { get; set; }

        public HoaDon(string MaHD, string Ngay, string MaHS, string MaNV, int SoTien, string GhiChu)
        {
            this.MaHD = MaHD;
            this.Ngay = Ngay;
            this.MaHS = MaHS;
            this.MaNV = MaNV;
            this.SoTien = SoTien;
            this.GhiChu = GhiChu;
        }

        public HoaDon(DataRow row)
        {
            bool success;
            int ketqua1;
            this.MaHD = row["MaHD"].ToString();
            this.Ngay = row["Ngay"].ToString();
            this.MaHS = row["MaHS"].ToString();
            this.MaNV = row["MaNV"].ToString();
            success = Int32.TryParse(row["SoTien"].ToString(), out ketqua1);
            this.SoTien = ketqua1;
            this.GhiChu = row["GhiChu"].ToString();
        }

        public HoaDon()
        {

        }
    }
}
