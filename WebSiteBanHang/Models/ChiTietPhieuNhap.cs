//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSiteBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuNhap
    {
        public int MaChiTietPN { get; set; }
        public Nullable<int> MaPN { get; set; }
        public Nullable<int> MaSP { get; set; }
        public Nullable<decimal> DonGiaNhap { get; set; }
        public Nullable<int> SoLuongNhap { get; set; }
    
        public virtual PhieuNhap PhieuNhap { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
