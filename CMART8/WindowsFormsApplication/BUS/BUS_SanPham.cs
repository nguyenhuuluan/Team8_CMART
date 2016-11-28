using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
{
    class BUS_SanPham
    {
       CMART8Entities db;
    public List<SANPHAM> loadListSP()
    { 
        db = new CMART8Entities();
        return db.SANPHAMs.ToList();
    }

    public List<SANPHAM> searchListSP(string sTmp)
    {
        db = new CMART8Entities();
        return db.SANPHAMs.Where(st => st.TENSP.Contains(sTmp) || st.HINHANH.Contains(sTmp) || st.MASP.Contains(sTmp) || st.MALOAI.Contains(sTmp)).ToList();
    }
    public bool addSP(string ten, string hinhanh, string maloai, string mancc)
    {
        db = new CMART8Entities();
        SANPHAM SP = new SANPHAM();
        try {
            SP.MASP = DateTime.Now.ToString();
            SP.TENSP = ten;
            SP.HINHANH = hinhanh;
            SP.MALOAI = maloai;
            SP.MANCC = mancc;
            db.SANPHAMs.AddObject(SP);
            db.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool editSP(string id, string ten, string hinhanh, string maloai, string mancc)
    {
        db = new CMART8Entities();
        SANPHAM SP = db.SANPHAMs.Single(st => st.MASP.Equals(id));
        try
        {
            SP.TENSP = ten;
            SP.HINHANH = hinhanh;
            SP.MALOAI = maloai;
            SP.MANCC = mancc;
            db.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool deleteSP(String id)
    {   
        db = new CMART8Entities();
        SANPHAM SP = db.SANPHAMs.Single(st => st.MASP.Contains(id));
        db.SANPHAMs.DeleteObject(SP);
        db.SaveChanges();
        return true;
    }
    public bool checkExist(string sTmp)
    { 
        db = new CMART8Entities();
        List<SANPHAM> tmp = db.SANPHAMs.Where(st=> st.TENSP.Equals(sTmp) ||st.MASP.Equals(sTmp)).ToList();
        if (tmp.Count != 0)
        {
            return false;
        }
        return true;
    }
    }
}
