//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLThuoc
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietDon
    {
        public int MaCTDT { get; set; }
        public Nullable<int> MaDon { get; set; }
        public Nullable<int> MaThuoc { get; set; }
        public Nullable<int> SoLuong { get; set; }
        public Nullable<decimal> ThanhTien { get; set; }
        public Nullable<bool> DaXoa { get; set; }
    
        public virtual DonThuoc DonThuoc { get; set; }
        public virtual Thuoc Thuoc { get; set; }
    }
}
