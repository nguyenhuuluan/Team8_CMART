using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8.Dexuat
{
    class BUS_DX
    {
        CMART8Entities db;
        public List<PHIEUDEXUAT> searchPDX(string sTmp)
        {
            db = new CMART8Entities();
            return db.PHIEUDEXUATs.ToList().Where(x => x.SOPHIEUDX.Contains(sTmp) || x.NGAYDEXUAT.ToString().Contains(sTmp) || x.MANCC.Contains(sTmp)).ToList();
        }
        public List<CTPHIEUDEXUAT> loadlistCTPDX(PHIEUDEXUAT pdx)
        {
            db = new CMART8Entities();
            return db.CTPHIEUDEXUATs.Where(x=>x.SOPHIEU.Equals(pdx.SOPHIEUDX)).ToList();
        }
        public List<PHIEUDEXUAT> loadlistPDX()
        {
            db = new CMART8Entities();
            return db.PHIEUDEXUATs.ToList();
        }
        //Hủy phiếu đề xuất
        public bool deletePDX(PHIEUDEXUAT pdx)
        {
            try
            {
                db = new CMART8Entities();
                List<CTPHIEUDEXUAT> lst = db.CTPHIEUDEXUATs.Where(x => x.SOPHIEU.Equals(pdx.SOPHIEUDX)).ToList();
                foreach (CTPHIEUDEXUAT item in lst)
                {
                    db.CTPHIEUDEXUATs.Remove(item);
                }
                db.SaveChanges();
                db = new CMART8Entities();
                PHIEUDEXUAT PDX = db.PHIEUDEXUATs.Find(pdx.SOPHIEUDX);
                db.PHIEUDEXUATs.Remove(PDX);
                db.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        //Delete CTPDX
        public bool deleteCTPDX(string masp, PHIEUDEXUAT pdx)
        {
            db = new CMART8Entities();
            try
            {
                CTPHIEUDEXUAT ctdx = db.CTPHIEUDEXUATs.Single(st => st.SOPHIEU.Equals(pdx.SOPHIEUDX) && st.MASP.Equals(masp));
                db.CTPHIEUDEXUATs.Remove(ctdx);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Add CTPDX
        public bool addCTPDX(string masp, string soluong, PHIEUDEXUAT pdx)
        {
            db = new CMART8Entities();
            try
            {
                try
                {
                    CTPHIEUDEXUAT ctdx = db.CTPHIEUDEXUATs.Single(st => st.SOPHIEU.Equals(pdx.SOPHIEUDX) && st.MASP.Equals(masp));
                    int dem = int.Parse(ctdx.SOLUONG.ToString()) + int.Parse(soluong);
                    ctdx.SOLUONG = dem;
                    db.SaveChanges();
                    return true;
                }
                catch
                {
                    CTPHIEUDEXUAT ctdx = new CTPHIEUDEXUAT();
                    ctdx.SOPHIEU = pdx.SOPHIEUDX;
                    ctdx.MASP = masp;
                    ctdx.SOLUONG = int.Parse(soluong);
                    db.CTPHIEUDEXUATs.Add(ctdx);
                    db.SaveChanges();
                    return true;
                }
            }
            catch {
                return false;

            }
        }
        private bool checkexitCTPDX(PHIEUDEXUAT pdx, string masp)
        {
            db = new CMART8Entities();
            List<CTPHIEUDEXUAT> tmp = db.CTPHIEUDEXUATs.Where(st => st.SOPHIEU.Equals(pdx.SOPHIEUDX) && st.MASP.Equals(masp)).ToList();
            if (tmp.Count != 0)
            {
                return false;
            }
            return true;
        }
        //Update PDX
        public bool updatePDX(PHIEUDEXUAT pdx, string mancc)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUDEXUAT dx = db.PHIEUDEXUATs.Find(pdx.SOPHIEUDX);
                dx.MANCC = mancc;
                db.Entry(dx).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
        public bool updatePDX(PHIEUDEXUAT pdx, string mancc, DateTime ngaydx)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUDEXUAT dx = db.PHIEUDEXUATs.Find(pdx.SOPHIEUDX);
                dx.MANCC = mancc;
                dx.NGAYDEXUAT = ngaydx;
                db.Entry(dx).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;

            }
        }
        //tao mới phiếu đề xuất
        public PHIEUDEXUAT createPDX(string maTK)
        {
            db = new CMART8Entities();
            PHIEUDEXUAT pdx = new PHIEUDEXUAT();
            pdx.SOPHIEUDX = autoID();
            pdx.NGAYDEXUAT = DateTime.Now;
            pdx.MATK = maTK;
            db.PHIEUDEXUATs.Add(pdx);
            db.SaveChanges();
            return pdx;
        }

        public string autoID()
        {
            db = new CMART8Entities();
            string s = "";
            string yy = DateTime.Now.Year.ToString();
            yy = yy.Substring(yy.Length - 2, 2);
            string mm = "0" + DateTime.Now.Month.ToString();
            mm = mm.Substring(mm.Length - 2, 2);
            string dd = "0" + DateTime.Now.Day.ToString();
            dd = dd.Substring(dd.Length - 2, 2);
            List<PHIEUDEXUAT> hd = db.PHIEUDEXUATs.Where(st => st.SOPHIEUDX.Substring(3, 6).Equals(yy + mm + dd)).ToList();
            hd = db.PHIEUDEXUATs.ToList().Where(h => h.SOPHIEUDX.Contains(yy + mm + dd)).ToList();
            if (hd.Count == 0)
            {
                s = "DX-" + yy + mm.Substring(mm.Length - 2, 2) + dd.Substring(dd.Length - 2, 2) + "-0001";
            }
            else
            {
                string mahd = "000" + hd.Select(h => h.SOPHIEUDX.Substring(10)).OrderBy(so => so).Last();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                int ma = int.Parse(mahd) + 1;
                mahd = "000" + ma.ToString();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                s = "DX-" + yy + mm + dd + "-" + mahd;
            }
            return s;
        }
    }
}
