using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPIData.DTO
{
    public class ThoiKhoaBieu
    {
        public string MaTKB { get; set; }
        public string NgayHoc { get; set; }
        public string ThoiGianHoc { get; set; }

        public ThoiKhoaBieu(string MaTKB, string NgayHoc, string ThoiGianHoc)
        {
            this.MaTKB = MaTKB;
            this.NgayHoc = NgayHoc;
            this.ThoiGianHoc = ThoiGianHoc;
        }

        public ThoiKhoaBieu(DataRow row)
        {
            this.MaTKB = row["MaTKB"].ToString();
            this.NgayHoc = row["NgayHoc"].ToString();
            this.ThoiGianHoc = row["ThoiGianHoc"].ToString();

        }

        public ThoiKhoaBieu()
        {

        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return true;
            }
            return false;
        }
    }
}
