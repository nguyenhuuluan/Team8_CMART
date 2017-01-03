using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_LoaiSanPham
    {
            CMART8Entities db;
            public List<LOAISANPHAM> loadListLSP()
            {
                db = new CMART8Entities();
                return db.LOAISANPHAMs.ToList();
            }

            public List<LOAISANPHAM> searchListLSP(string sTmp)
            {
                db = new CMART8Entities();
                //int tmp = int.Parse(sTmp.Trim());
                return db.LOAISANPHAMs.ToList().Where(st => st.MALOAI.Contains(sTmp) || st.TENLOAI.Contains(sTmp)|| st.SOLUONGSP.ToString().Contains(sTmp)).ToList();
                
            }
            public bool addLSP(string ten)
            {
                db = new CMART8Entities();
                LOAISANPHAM LSP = new LOAISANPHAM();
                try
                {
                    LSP.MALOAI = DateTime.Now.ToString();
                    LSP.TENLOAI = ten;
                    LSP.SOLUONGSP = 0;
                    db.LOAISANPHAMs.Add(LSP);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public bool editLSP(string id, string ten)
            {
                db = new CMART8Entities();
                LOAISANPHAM LSP = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(id));
                try
                {
                    LSP.TENLOAI = ten;
                    db.SaveChanges();

                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public bool deleteLSP(String id)
            {
                try
                {
                    db = new CMART8Entities();
                    LOAISANPHAM LSP = db.LOAISANPHAMs.Single(st => st.MALOAI.Contains(id));
                    db.LOAISANPHAMs.Remove(LSP);
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
                List<LOAISANPHAM> tmp = db.LOAISANPHAMs.Where(st => st.TENLOAI.Equals(sTmp) || st.MALOAI.Equals(sTmp)).ToList();
                if (tmp.Count != 0)
                {
                    return false;
                }
                return true;
            }
        }
    }
