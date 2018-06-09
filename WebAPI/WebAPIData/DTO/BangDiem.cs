using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class BangDiem
    {
        public string MaBangDiem { get; set; }
        public string MaHS { get; set; }
        public string Ngay { get; set; }
        public double DiemHocTap { get; set; }
        public double DiemYThuc { get; set; }

        public BangDiem(string MaBangDiem, string MaHS, string Ngay, double DiemHocTap, double DiemYThuc)
        {
            this.MaBangDiem = MaBangDiem;
            this.MaHS = MaHS;
            this.Ngay = Ngay;
            this.DiemHocTap = DiemHocTap;
            this.DiemYThuc = DiemYThuc;
        }

        public BangDiem(DataRow row)
        {
            bool success;
            double ketqua1;
            double ketqua2;
            this.MaBangDiem = row["MaBangDiem"].ToString();
            this.MaHS = row["MaHS"].ToString();
            this.Ngay = row["Ngay"].ToString();
            success = Double.TryParse(row["DiemHocTap"].ToString(), out ketqua1);
            this.DiemHocTap = ketqua1;
            success = Double.TryParse(row["DiemYThuc"].ToString(), out ketqua2);
            this.DiemYThuc = ketqua2;

        }

        public BangDiem()
        {

        }
    }
}
