//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebMVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDD
    {
        public int IDDiemDanh { get; set; }
        public string MaHS { get; set; }
        public Nullable<bool> TinhTrangDD { get; set; }
        public string GhiChu { get; set; }
    
        public virtual GVDiemDanhH GVDiemDanhH { get; set; }
        public virtual HocSinh HocSinh { get; set; }
    }
}
