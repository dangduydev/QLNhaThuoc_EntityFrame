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
    
    public partial class CTPhieuNhap
    {
        public string MaPN { get; set; }
        public string MaThuoc { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> DonGia { get; set; }
        public Nullable<System.DateTime> NgaySX { get; set; }
        public Nullable<System.DateTime> NgayHH { get; set; }
    
        public virtual Thuoc Thuoc { get; set; }
        public virtual PhieuNhap PhieuNhap { get; set; }
    }
}
