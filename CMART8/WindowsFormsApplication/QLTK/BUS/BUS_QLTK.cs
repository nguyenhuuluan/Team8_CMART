using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_QLTK
    {
        CMART8Entities db;
        public List<TAIKHOAN> loadListTK()
        {
            db = new CMART8Entities();
            return db.TAIKHOANs.ToList();
        }

        public List<TAIKHOAN> searchListTK(string sTmp)
        {
            db = new CMART8Entities();
            return db.TAIKHOANs.ToList().Where(st => st.MATK.Contains(sTmp) || st.HOTEN.ToString().Contains(sTmp) || st.DIACHI.ToString().Contains(sTmp) || st.SDT.ToString().Contains(sTmp)
                || st.CMND.ToString().Contains(sTmp) || st.TENDANGNHAP.ToString().Contains(sTmp) || st.QUYEN.ToString().Contains(sTmp)).ToList();
        }
        public bool addTK( string hoten, string diachi, string sdt, string cmnd, string tendn, string matkhau, string quyen)
        {
            db = new CMART8Entities();
            TAIKHOAN TK = new TAIKHOAN();
            try
            {
                TK.MATK = DateTime.Now.ToString();
                TK.HOTEN = hoten;
                TK.DIACHI = diachi;
                TK.SDT = sdt;
                TK.CMND = cmnd;
                TK.TENDANGNHAP = tendn;
                TK.MATKHAU = matkhau;
                TK.QUYEN = quyen;
                db.TAIKHOANs.Add(TK);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editTK(string ID, string hoten, string diachi, string sdt, string cmnd, string tendn, string quyen)
        {
            db = new CMART8Entities();

            try
            {
                TAIKHOAN TK = db.TAIKHOANs.ToList().Single(st => st.MATK.Equals(ID));
                TK.HOTEN = hoten;
                TK.DIACHI = diachi;
                TK.SDT = sdt;
                TK.CMND = cmnd;
                TK.TENDANGNHAP = tendn;
                TK.QUYEN = quyen;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editTK(string ID, string hoten, string diachi, string sdt, string cmnd, string tendn, string matkhau, string quyen)
        {
            db = new CMART8Entities();

            try
            {
                TAIKHOAN TK = db.TAIKHOANs.ToList().Single(st => st.MATK.Equals(ID));
                TK.HOTEN = hoten;
                TK.DIACHI = diachi;
                TK.SDT = sdt;
                TK.CMND = cmnd;
                TK.TENDANGNHAP = tendn;
                TK.MATKHAU = matkhau;
                TK.QUYEN = quyen;
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteTK(string ID)
        {
            db = new CMART8Entities();
            TAIKHOAN TK = db.TAIKHOANs.ToList().Single(st => st.MATK.Equals(ID));
            db.TAIKHOANs.Remove(TK);
            db.SaveChanges();
            return true;
        }
        public bool checkExit(string username)
        {
            db = new CMART8Entities();
            List<TAIKHOAN> tmp = db.TAIKHOANs.Where(st => st.TENDANGNHAP.Equals(username)).ToList();
            if (tmp.Count != 0)
            {
                return false;
            }
            return true;

        }
    }
}
