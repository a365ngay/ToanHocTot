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
    
    public partial class Loptt
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Loptt()
        {
            this.HocSinhs = new HashSet<HocSinh>();
        }
    
        public string MaLoptt { get; set; }
        public string TenLoptt { get; set; }
        public string MaGV { get; set; }
        public string MaCS { get; set; }
        public string MaTKB { get; set; }
    
        public virtual CoSo CoSo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<HocSinh> HocSinhs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual ThoiKhoaBieu ThoiKhoaBieu { get; set; }
    }
}
