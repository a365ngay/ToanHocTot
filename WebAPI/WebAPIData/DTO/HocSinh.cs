using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class HocSinh
    {
        public string MaHS { get; set; }
        public string TenHS { get; set; }
        public string Lop { get; set; }
        public string Truong { get; set; }
        public string Loptt { get; set; }

        public HocSinh(string MaHS, string TenHS, string Lop, string Truong, string Loptt)
        {
            this.MaHS = MaHS;
            this.TenHS = TenHS;
            this.Lop = Lop;
            this.Truong = Truong;
            this.Loptt = Loptt;
        }

        public HocSinh(DataRow row)
        {
            this.MaHS = row["MaHS"].ToString();
            this.TenHS = row["TenHS"].ToString();
            this.Lop = row["Lop"].ToString();
            this.Truong = row["Truong"].ToString();
            this.Loptt = row["Loptt"].ToString();

        }

        public HocSinh()
        {

        }
    }
}
