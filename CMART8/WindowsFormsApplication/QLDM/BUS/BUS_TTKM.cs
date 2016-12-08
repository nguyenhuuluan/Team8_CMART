using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication
{
    class BUS_TTKM
    {
        CMART8Entities db = new CMART8Entities();
        public List<KHUYENMAI> loadListTTKM()
        {
            db = new CMART8Entities();
            return db.KHUYENMAIs.ToList();
        }

        public List<KHUYENMAI> searchListTTKM(string sTmp)
        {
            db = new CMART8Entities();
            return db.KHUYENMAIs.ToList().Where(st => st.MAKM.Contains(sTmp) || st.MASP.Contains(sTmp) || st.NOIDUNG.Contains(sTmp) || st.HINHANH.Contains(sTmp) || st.GIAKM.ToString().Contains(sTmp) || st.THOIGIANBD.ToString().Contains(sTmp) || st.THOIGIANKT.ToString().Contains(sTmp)).ToList();
            
        }
        public bool addTTKM(string masp, float giakm, DateTime tgbd, DateTime tgkt, string noidung,  string hinhanh)
        {
            db = new CMART8Entities();
            KHUYENMAI TTKM = new KHUYENMAI();
            try
            {
                TTKM.MAKM = DateTime.Now.ToString();
                TTKM.MASP = masp;
                TTKM.GIAKM = giakm;
                TTKM.HINHANH = hinhanh;
                //TTKM.THOIGIANBD = DateTime.Parse(tgbd);
                //TTKM.THOIGIANKT = DateTime.Parse(tgkt);
                TTKM.THOIGIANBD = tgbd;
                TTKM.THOIGIANKT = tgkt;
                TTKM.NOIDUNG = noidung;
                db.KHUYENMAIs.AddObject(TTKM);
                db.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool editTTKM(string makm, string masp, float giakm, DateTime tgbd, DateTime tgkt, string noidung, string hinhanh)
        {
            db = new CMART8Entities();
            KHUYENMAI TTKM = db.KHUYENMAIs.Single(st => st.MAKM.Equals(makm));
            try
            {
                TTKM.MASP = masp;
                TTKM.GIAKM = giakm;
                TTKM.HINHANH = hinhanh;
                //TTKM.THOIGIANBD = DateTime.Parse(tgbd);
                //TTKM.THOIGIANKT = DateTime.Parse(tgkt);
                TTKM.THOIGIANBD = tgbd;
                TTKM.THOIGIANKT = tgkt;
                TTKM.NOIDUNG = noidung;
                db.SaveChanges();

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool deleteTTKM(String id)
        {
            db = new CMART8Entities();
            KHUYENMAI TTKM = db.KHUYENMAIs.Single(st => st.MAKM.Contains(id));
            db.KHUYENMAIs.DeleteObject(TTKM);
            db.SaveChanges();
            return true;
        }
        public bool checkExist(string sTmp)
        {
            db = new CMART8Entities();
            List<KHUYENMAI> tmp = db.KHUYENMAIs.Where(st => st.MAKM.Equals(sTmp)).ToList();
            if (tmp.Count != 0)
            {
                return false;
            }
            return true;
        }
    }
}
