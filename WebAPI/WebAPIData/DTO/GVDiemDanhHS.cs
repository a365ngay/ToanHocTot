using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class GVDiemDanhHS
    {
        public int IDDiemDanh { get; set; }
        public string MaNV { get; set; }
        public string Malop { get; set; }
        public string NgayDD { get; set; }

        public GVDiemDanhHS(int IDDiemDanh, string MaNV, string Malop, string NgayDD)
        {
            this.IDDiemDanh = IDDiemDanh;
            this.MaNV = MaNV;
            this.Malop = Malop;
            this.NgayDD = NgayDD;
        }

        public GVDiemDanhHS(DataRow row)
        {
            this.IDDiemDanh = int.Parse(row["IDDiemDanh"].ToString());
            this.MaNV = row["MaNV"].ToString();
            this.Malop = row["Malop"].ToString();
            this.NgayDD = row["NgayDD"].ToString();

        }

        public GVDiemDanhHS()
        {

        }
    }
}
