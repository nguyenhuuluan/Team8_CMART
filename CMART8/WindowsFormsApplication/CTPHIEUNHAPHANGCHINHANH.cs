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
    
    public partial class CTPHIEUNHAPHANGCHINHANH
    {
        public string SOPHIEUNHCN { get; set; }
        public string MASP { get; set; }
        public Nullable<int> SOLUONG { get; set; }
        public string TINHTRANG { get; set; }
    
        public virtual PHIEUNHAPHANGCHINHANH PHIEUNHAPHANGCHINHANH { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}