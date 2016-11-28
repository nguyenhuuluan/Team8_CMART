using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
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
                return db.LOAISANPHAMs.Where(st => st.TENLOAI.Contains(sTmp) || st.SOLUONGSP.Equals(int.Parse(sTmp))).ToList();
            }
            public bool addLSP(string ten, int soluong)
            {
                db = new CMART8Entities();
                LOAISANPHAM LSP = new LOAISANPHAM();
                try
                {
                    LSP.MALOAI = DateTime.Now.ToString();
                    LSP.TENLOAI = ten;
                    LSP.SOLUONGSP = soluong;
                    db.LOAISANPHAMs.AddObject(LSP);
                    db.SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
            public bool editLSP(string id, string ten, int soluong)
            {
                db = new CMART8Entities();
                LOAISANPHAM LSP = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(id));
                try
                {
                    LSP.TENLOAI = ten;
                    LSP.SOLUONGSP = soluong;
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
                db = new CMART8Entities();
                LOAISANPHAM LSP = db.LOAISANPHAMs.Single(st => st.MALOAI.Contains(id));
                db.LOAISANPHAMs.DeleteObject(LSP);
                db.SaveChanges();
                return true;
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
