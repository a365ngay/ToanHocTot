using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class ChiTietDD
    {
        public int IDDiemDanh { get; set; }
        public string MaHS { get; set; }
        public string TinhTrangDD { get; set; }
        public string GhiChu { get; set; }

        public ChiTietDD(int IDDiemDanh, string MaHS, string TinhTrangDD, string GhiChu)
        {
            this.IDDiemDanh = IDDiemDanh;
            this.MaHS = MaHS;
            this.TinhTrangDD = TinhTrangDD;
            this.GhiChu = GhiChu;
        }

        public ChiTietDD(DataRow row)
        {
            this.IDDiemDanh = int.Parse(row["IDDiemDanh"].ToString());
            this.MaHS = row["MaHS"].ToString();
            this.TinhTrangDD = row["TinhTrangDD"].ToString();
            this.GhiChu = row["GhiChu"].ToString();

        }

        public ChiTietDD()
        {

        }
    }
}
