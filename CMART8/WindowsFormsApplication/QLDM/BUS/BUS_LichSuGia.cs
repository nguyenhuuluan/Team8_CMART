using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_LichSuGia
    {
        CMART8Entities db;
        public List<LICHSUGIA> loadListSP()
        {
            db = new CMART8Entities();
            return db.LICHSUGIAs.ToList().OrderBy(st=>st.NGAYHIEULUC).ToList();
        }

        public List<LICHSUGIA> searchListLSG(string sTmp)
        {
            db = new CMART8Entities();
            return db.LICHSUGIAs.ToList().Where(st => st.MASP.Contains(sTmp) || st.GIABAN.ToString().Contains(sTmp) || st.NGAYHIEULUC.ToString().Contains(sTmp)).ToList();
        }
        public bool addLSG(string ID, string gia, DateTime ngayhl)
        {
            db = new CMART8Entities();
            LICHSUGIA LSG = new LICHSUGIA();
            try
            {
                LSG.MASP = ID;
                LSG.GIABAN = int.Parse(gia);
                LSG.NGAYHIEULUC = ngayhl;       
                db.LICHSUGIAs.Add(LSG);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editLSG(string ID, string gia, string ngayhl, string ID2, string gia2, DateTime ngayhl2)
        {
            db = new CMART8Entities();
           
            try
            {
                LICHSUGIA LSG = db.LICHSUGIAs.ToList().Single(st => st.MASP.Equals(ID) && st.GIABAN.ToString().Equals(gia) && st.NGAYHIEULUC.ToString().Equals(ngayhl));
                LICHSUGIA tmp = LSG;
                db.LICHSUGIAs.Remove(LSG);
                db.SaveChanges();
                db = new CMART8Entities();
                tmp.GIABAN = int.Parse(gia2);
                tmp.NGAYHIEULUC = ngayhl2;
                tmp.MASP = ID2;
                db.LICHSUGIAs.Add(tmp);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteLSG(string ID, string gia, string ngayhl)
        {
            db = new CMART8Entities();
            LICHSUGIA LSG = db.LICHSUGIAs.ToList().Single(st => st.MASP.Equals(ID) && st.GIABAN.ToString().Equals(gia) && st.NGAYHIEULUC.ToString().Equals(ngayhl));
            db.LICHSUGIAs.Remove(LSG);
            db.SaveChanges();
            return true;
        }
    }
}
