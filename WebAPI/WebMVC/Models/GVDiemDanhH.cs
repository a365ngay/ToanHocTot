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
    
    public partial class GVDiemDanhH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GVDiemDanhH()
        {
            this.ChiTietDDs = new HashSet<ChiTietDD>();
        }
    
        public int IDDiemDanh { get; set; }
        public string MaNV { get; set; }
        public string Malop { get; set; }
        public Nullable<System.DateTime> NgayDD { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ChiTietDD> ChiTietDDs { get; set; }
        public virtual NhanVien NhanVien { get; set; }
    }
}
