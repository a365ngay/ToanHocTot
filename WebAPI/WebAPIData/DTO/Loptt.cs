using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class Loptt
    {
        public string MaLoptt { get; set; }
        public string TenLoptt { get; set; }
        public string MaGV { get; set; }
        public string MaCS { get; set; }
        public string MaTKB { get; set; }

        public Loptt(string MaLoptt, string TenLoptt, string MaGV, string MaCS, string MaTKB)
        {
            this.MaLoptt = MaLoptt;
            this.TenLoptt = TenLoptt;
            this.MaGV = MaGV;
            this.MaCS = MaCS;
            this.MaTKB = MaTKB;
        }

        public Loptt(DataRow row)
        {
            this.MaLoptt = row["MaLoptt"].ToString();
            this.TenLoptt = row["TenLoptt"].ToString();
            this.MaGV = row["MaGV"].ToString();
            this.MaCS = row["MaCS"].ToString();
            this.MaTKB = row["MaTKB"].ToString();

        }

        public Loptt()
        {

        }
    }
}
