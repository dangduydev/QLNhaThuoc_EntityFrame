//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Phacmarcity_ADO.NET
{
    using System;
    using System.Collections.Generic;
    
    public partial class Thuoc
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Thuoc()
        {
            this.CTPhieuNhaps = new HashSet<CTPhieuNhap>();
            this.CTPhieuXuats = new HashSet<CTPhieuXuat>();
            this.CTPhieuXuats1 = new HashSet<CTPhieuXuat>();
        }
    
        public string MaThuoc { get; set; }
        public string TenThuoc { get; set; }
        public string MaHangSX { get; set; }
        public string MaNhaCungCap { get; set; }
        public string CongDung { get; set; }
        public string GhiChu { get; set; }
        public Nullable<int> SoLuong { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuNhap> CTPhieuNhaps { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> CTPhieuXuats { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CTPhieuXuat> CTPhieuXuats1 { get; set; }
        public virtual HangSX HangSX { get; set; }
        public virtual NhaCungCap NhaCungCap { get; set; }
    }
}
