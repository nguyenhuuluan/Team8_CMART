//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CMART8
{
    using System;
    using System.Collections.Generic;
    
    public partial class TAIKHOAN
    {
        public TAIKHOAN()
        {
            this.HOADONs = new HashSet<HOADON>();
            this.PHIEUDEXUATs = new HashSet<PHIEUDEXUAT>();
            this.PHIEUNHAPHANGCHINHANHs = new HashSet<PHIEUNHAPHANGCHINHANH>();
        }
    
        public string MATK { get; set; }
        public string HOTEN { get; set; }
        public string DIACHI { get; set; }
        public string SDT { get; set; }
        public string CMND { get; set; }
        public string TENDANGNHAP { get; set; }
        public string MATKHAU { get; set; }
        public string QUYEN { get; set; }
    
        public virtual ICollection<HOADON> HOADONs { get; set; }
        public virtual ICollection<PHIEUDEXUAT> PHIEUDEXUATs { get; set; }
        public virtual ICollection<PHIEUNHAPHANGCHINHANH> PHIEUNHAPHANGCHINHANHs { get; set; }
    }
}
