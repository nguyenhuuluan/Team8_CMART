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
        LOAISANPHAM lsp = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(maloai));
        try {
            SP.MASP = DateTime.Now.ToString();
            SP.TENSP = ten;
            SP.HINHANH = hinhanh;
            SP.MALOAI = maloai;
            SP.MANCC = mancc;
            db.SANPHAMs.AddObject(SP);
            lsp.SOLUONGSP = lsp.SOLUONGSP + 1;
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
            if (maloai != SP.MALOAI)
            {
                LOAISANPHAM lsp1 = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(maloai));
                LOAISANPHAM lsp2 = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(SP.MALOAI));
                SP.TENSP = ten;
                SP.HINHANH = hinhanh;
                SP.MALOAI = maloai;
                SP.MANCC = mancc;
                lsp2.SOLUONGSP = lsp2.SOLUONGSP - 1;
                lsp1.SOLUONGSP = lsp1.SOLUONGSP + 1;
                db.SaveChanges();
            }
            else {
                SP.TENSP = ten;
                SP.HINHANH = hinhanh;
                SP.MANCC = mancc;
                db.SaveChanges();
            }
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
        LOAISANPHAM lsp = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(SP.MALOAI));
        db.SANPHAMs.DeleteObject(SP);
        lsp.SOLUONGSP = lsp.SOLUONGSP - 1;
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
