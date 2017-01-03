using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_NHCN
    {
        CMART8Entities db;
        public List<PHIEUNHAPHANGCHINHANH> search(string sTmp)
        {
            db = new CMART8Entities();
            return db.PHIEUNHAPHANGCHINHANHs.ToList().Where(x => x.SOPHIEU.Contains(sTmp) || x.SOPHIEUNHTS.Contains(sTmp)
                || x.NGAYNHAP.ToString().Contains(sTmp) || x.CHINHANH.Contains(sTmp)).ToList();
        }
        public List<PHIEUNHAPHANGCHINHANH> loadListNHCN()
        {
            db = new CMART8Entities();
            return db.PHIEUNHAPHANGCHINHANHs.ToList();
        }
        public PHIEUNHAPHANGCHINHANH createNHCN(TAIKHOAN tk)
        {
            db = new CMART8Entities();
            PHIEUNHAPHANGCHINHANH pnh = new PHIEUNHAPHANGCHINHANH();
            pnh.SOPHIEU = autoID();
            pnh.NGAYNHAP = DateTime.Now;
            pnh.MATK = tk.MATK;
            db.PHIEUNHAPHANGCHINHANHs.Add(pnh);
            db.SaveChanges();
            return pnh;
        }
        //add chi tiết phiếu nhập hàng chi nhánh
        public bool addListCTNHCN(List<CTPHIEUNHAPHANGCHINHANH> list)
        {
            try
            {
                db = new CMART8Entities();
                foreach (CTPHIEUNHAPHANGCHINHANH item in list)
                {
                    db.CTPHIEUNHAPHANGCHINHANHs.Add(item);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        //Update Phiếu nhập hàng chi nhánh
        public bool updatePNHTS(PHIEUNHAPHANGCHINHANH PN, string sophieuTS, string chinhanh)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGCHINHANH pn = db.PHIEUNHAPHANGCHINHANHs.Find(PN.SOPHIEU);
                pn.SOPHIEUNHTS = sophieuTS;
                pn.CHINHANH = chinhanh;
                db.Entry(pn).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
        //load dữ liệu sau khi select combobox, CTPHieu tru so
        public List<CTPHIEUNHAPHANGTRUSO> loadListCTTS(string sophieuts)
        {
            db = new CMART8Entities();
            return db.CTPHIEUNHAPHANGTRUSOes.Where(x => x.SOPHIEUNHTS.Equals(sophieuts)).ToList();
        }
        //load dữ liệu cho combobox
        public List<PHIEUNHAPHANGTRUSO> loadListNHTS()
        {
            db = new CMART8Entities();
            List<PHIEUNHAPHANGTRUSO> pdx = db.PHIEUNHAPHANGTRUSOes.ToList();

            for (int i = pdx.Count - 1; i >= 0; i--)
            {
                if (!checkExit(pdx.ElementAt(i).SOPHIEU))
                {
                    pdx.RemoveAt(i);
                }
            }
            return pdx;
        }
        public bool checkExit(string soPhieu)
        {
            db = new CMART8Entities();
            List<PHIEUNHAPHANGCHINHANH> tmp = db.PHIEUNHAPHANGCHINHANHs.Where(st => st.SOPHIEUNHTS.Equals(soPhieu)).ToList();
            if (tmp.Count != 0)
            {
                return false;
            }
            return true;
        }
        public bool deletePN(PHIEUNHAPHANGCHINHANH PN)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGCHINHANH pn = db.PHIEUNHAPHANGCHINHANHs.Find(PN.SOPHIEU);
                db.PHIEUNHAPHANGCHINHANHs.Remove(pn);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
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
            List<PHIEUNHAPHANGCHINHANH> hd = db.PHIEUNHAPHANGCHINHANHs.Where(st => st.SOPHIEU.Substring(3, 6).Equals(yy + mm + dd)).ToList();
            hd = db.PHIEUNHAPHANGCHINHANHs.ToList().Where(h => h.SOPHIEU.Contains(yy + mm + dd)).ToList();
            if (hd.Count == 0)
            {
                s = "CN-" + yy + mm.Substring(mm.Length - 2, 2) + dd.Substring(dd.Length - 2, 2) + "-0001";
            }
            else
            {
                string mahd = "000" + hd.Select(h => h.SOPHIEU.Substring(10)).OrderBy(so => so).Last();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                int ma = int.Parse(mahd) + 1;
                mahd = "000" + ma.ToString();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                s = "CN-" + yy + mm + dd + "-" + mahd;
            }
            return s;
        }
    }
}
