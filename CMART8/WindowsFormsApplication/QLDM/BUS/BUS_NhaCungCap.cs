using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_NhaCungCap
    {   CMART8Entities db;
    public List<NHACUNGCAP> loadListNCC()
    { 
        db = new CMART8Entities();
        return db.NHACUNGCAPs.ToList();
    }

    public List<NHACUNGCAP> searchListNCC(string sTmp)
    {
        db = new CMART8Entities();
        return db.NHACUNGCAPs.Where(st => st.DIACHI.Contains(sTmp) || st.TENNCC.Contains(sTmp) || st.SDT.Contains(sTmp)).ToList();
    }
    public bool addNCC(string ten, string diachi, string sdt)
    {
        db = new CMART8Entities();
        NHACUNGCAP ncc = new NHACUNGCAP();
        try {
            ncc.MANCC = DateTime.Now.ToString();
            ncc.TENNCC = ten;
            ncc.DIACHI = diachi;
            ncc.SDT = sdt;
            db.NHACUNGCAPs.Add(ncc);
            db.SaveChanges();
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool editNCC(string id, string ten, string diachi, string sdt)
    {
        db = new CMART8Entities();
        NHACUNGCAP ncc = db.NHACUNGCAPs.Single(st => st.MANCC.Equals(id));
        try
        {
            ncc.TENNCC = ten;
            ncc.DIACHI = diachi;
            ncc.SDT = sdt;
            db.SaveChanges();

            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }
    public bool deleteNCC(String id)
    {
        try
        {
            db = new CMART8Entities();
            NHACUNGCAP ncc = db.NHACUNGCAPs.Single(st => st.MANCC.Contains(id));
            db.NHACUNGCAPs.Remove(ncc);
            db.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        }
    }
    public bool checkExist(string sTmp)
    { 
        db = new CMART8Entities();
        List<NHACUNGCAP> tmp = db.NHACUNGCAPs.Where(st=> st.TENNCC.Equals(sTmp) ||st.MANCC.Equals(sTmp)).ToList();
        if (tmp.Count != 0)
        {
            return false;
        }
        return true;
    }


    }
}
