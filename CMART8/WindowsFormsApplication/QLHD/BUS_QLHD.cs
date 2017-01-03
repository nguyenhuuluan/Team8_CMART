using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_QLHD
    {
        CMART8Entities db;
        public List<CTHOADON> searchCTHD(string sTmp, HOADON HD)
        {
            db = new CMART8Entities();
            return db.CTHOADONs.ToList().Where(x => x.SOHD.Equals(HD.SOHD) && x.MASP.Contains(sTmp)).ToList();
        }
        public List<HOADON> search(string sTmp)
        {
            db = new CMART8Entities();
            return db.HOADONs.ToList().Where(x => x.SOHD.Contains(sTmp) || x.NGAYBAN.ToString().Contains(sTmp)
                || x.TONGTIEN.Contains(sTmp) || x.TIENKHACHDUA.Contains(sTmp) || x.TIENKHATRA.Contains(sTmp) || x.TONGSL.ToString().Contains(sTmp)).ToList();
        }
        public List<HOADON> loadListHD()
        {
            db = new CMART8Entities();
            return db.HOADONs.ToList();
        }
        public List<CTHOADON> loadListCTHD(string sohd)
        {
            db = new CMART8Entities();
            return db.CTHOADONs.ToList().Where(st => st.SOHD.Equals(sohd)).ToList();
        }
        public bool updateHD(string id, string tongtien, string tienkh, string tientra, string tongsl)
        {
            try
            {
                db = new CMART8Entities();
                HOADON hd = db.HOADONs.Single(st => st.SOHD.Equals(id));
                hd.TONGTIEN = tongtien;
                hd.TIENKHACHDUA = tienkh;
                hd.TIENKHATRA = tientra;
                hd.TONGSL = int.Parse(tongsl);
                db.SaveChanges();
                return true;
            }
            catch {

                return false;
            }
        }
        public bool addSP(string mahd, string masp, string sl, string dongia)
        {
            db = new CMART8Entities();
            try
            {
                try {

                    CTHOADON cthd = db.CTHOADONs.Single(st => st.SOHD.Equals(mahd) && st.MASP.Equals(masp));
                    int dem = int.Parse(cthd.SOLUONG.ToString()) + int.Parse(sl);
                    cthd.SOLUONG = dem;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    CTHOADON cthd = new CTHOADON();
                    cthd.SOHD = mahd;
                    cthd.MASP = masp;
                    cthd.DONGIA = float.Parse(dongia);
                    cthd.SOLUONG = int.Parse(sl);
                    db.CTHOADONs.Add(cthd);
                    db.SaveChanges();
                    return true;
                }
            }
            catch
            { return false; }
        }
        public bool deleteHD(string sohd)
        {
            db = new CMART8Entities();
            try
            {
                HOADON HD = db.HOADONs.Single(st => st.SOHD.Equals(sohd));
                List<CTHOADON> cthd = db.CTHOADONs.Where(st => st.SOHD.Equals(sohd)).ToList();
                foreach(CTHOADON tmp in cthd)
                {
                    db.CTHOADONs.Remove(tmp);               
                }
                db.SaveChanges();
                db.HOADONs.Remove(HD);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool deleteSP(string sohd, string masp)
        {
            db = new CMART8Entities();
            try
            {
                CTHOADON cthd = db.CTHOADONs.Single(st => st.SOHD.Equals(sohd) && st.MASP.Equals(masp));
                db.CTHOADONs.Remove(cthd);
                db.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        public HOADON createHD(string POS, string maTK)
        {
            db = new CMART8Entities();
            string id = autoID();
            HOADON hd = new HOADON();
            hd.SOHD = id;
            hd.NGAYBAN = DateTime.Now;
            hd.MATK = maTK;
            hd.POS = POS;
            hd.TONGSL = 0;
            hd.TONGTIEN = "0";
            hd.TIENKHACHDUA = "0";
            hd.TIENKHATRA = "0";
            db.HOADONs.Add(hd);
            db.SaveChanges();
            return hd;
        }
        public string autoID()
        {
            db = new CMART8Entities();
            string s ="";
            string yy = DateTime.Now.Year.ToString();
            yy = yy.Substring(yy.Length - 2, 2);
            string mm = "0"+DateTime.Now.Month.ToString();
            mm = mm.Substring(mm.Length - 2, 2);
            string dd = "0"+DateTime.Now.Day.ToString();
            dd = dd.Substring(dd.Length - 2, 2);
            List<HOADON> hd = db.HOADONs.Where(st => st.SOHD.Substring(3, 6).Equals(yy + mm + dd)).ToList();
            hd = db.HOADONs.ToList().Where(h => h.SOHD.Contains(yy + mm + dd)).ToList();
            if (hd.Count == 0)
            {
                s = "HD-" + yy + mm.Substring(mm.Length-2,2) + dd.Substring(dd.Length-2,2) + "-0001";
            }
            else
            {
                //var max = db.HOADONs.Where(st=> st.SOHD.Substring(3,6).Equals(yy+mm+dd)).Max(x=>x.SOHD.Substring(10,4));
                //HOADON tmp =db.HOADONs.First(x=>x.SOHD == max);
                string mahd = "000"+hd.Select(h => h.SOHD.Substring(10)).OrderBy(so => so).Last();
                mahd = mahd.Substring(mahd.Length-4,4);
                int ma = int.Parse(mahd) + 1;
                mahd = "000" + ma.ToString();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                //HOADON tmp = hd.First();
                //int ma = Convert.ToInt32(tmp.SOHD.Substring(10, 4))+1;
                //int ma = int.Parse(tmp.SOHD.Substring(10, 4))+1;

                s = "HD-" + yy + mm + dd +  "-"+ mahd;
            }
            return s;
        }
    }
}
