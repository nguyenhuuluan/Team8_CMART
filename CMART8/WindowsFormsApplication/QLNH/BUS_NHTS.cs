using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{
    class BUS_NHTS
    {
        CMART8Entities db;
        public List<PHIEUNHAPHANGTRUSO> search(string sTmp)
        {
            db = new CMART8Entities();
            return db.PHIEUNHAPHANGTRUSOes.ToList().Where(x => x.SOPHIEU.Contains(sTmp) || x.SOPHIEUDX.Contains(sTmp) ||
                x.TONGTIEN.ToString().Contains(sTmp) || x.NGAYNHAP.ToString().Contains(sTmp)).ToList();
        }
        public List<PHIEUNHAPHANGTRUSO> loadListNHTS()
        {
            db = new CMART8Entities();
            return db.PHIEUNHAPHANGTRUSOes.ToList();
        }

        //add list Chi tiết phiếu nhập hàng trụ sở
        public bool addListCTNHTS(List<CTPHIEUNHAPHANGTRUSO> list)
        {
            try
            {
                db = new CMART8Entities();
                foreach (CTPHIEUNHAPHANGTRUSO item in list)
                {
                    db.CTPHIEUNHAPHANGTRUSOes.Add(item);
                }
                db.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        //update Phieu nhap hang tru so
        public bool updatePNHTS(PHIEUNHAPHANGTRUSO PN, string tongTien, string soPhieuDX)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGTRUSO pn = db.PHIEUNHAPHANGTRUSOes.Find(PN.SOPHIEU);
                pn.TONGTIEN = ulong.Parse(tongTien);
                pn.SOPHIEUDX = soPhieuDX;
                db.Entry(pn).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch{

                return false;
            }
        }
        public void deleteListCTNHTS(string sophieuts)
        {
            db = new CMART8Entities();
            List<CTPHIEUNHAPHANGTRUSO> tmp = db.CTPHIEUNHAPHANGTRUSOes.Where(x=>x.SOPHIEUNHTS.Equals(sophieuts)).ToList();
            foreach (CTPHIEUNHAPHANGTRUSO p in tmp)
            {
                db.CTPHIEUNHAPHANGTRUSOes.Remove(p);
            }
            db.SaveChanges();
        }
        //Delete PN
        public bool deletePN(PHIEUNHAPHANGTRUSO PN)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGTRUSO pn = db.PHIEUNHAPHANGTRUSOes.Find(PN.SOPHIEU);
                db.PHIEUNHAPHANGTRUSOes.Remove(pn);
                db.SaveChanges();
                return true;
            }
            catch {
                return false;
            }
        }
        //Load Chi tiết phiếu nhập hàng trụ sở sau khi select combobox
        //Load chitiet phiếu đề xuất
        public List<CTPHIEUDEXUAT> loadListCTDX(string sophieudx) { 
            db = new CMART8Entities();
            return db.CTPHIEUDEXUATs.Where(x => x.SOPHIEU.Equals(sophieudx)).ToList();
        }
        //Load combobox
        public List<PHIEUDEXUAT> loadListPDX()
        {
            db = new CMART8Entities();
            List<PHIEUDEXUAT> pdx = db.PHIEUDEXUATs.ToList();

            for (int i = pdx.Count - 1; i >= 0; i--)
            {
                if (!checkExit(pdx.ElementAt(i).SOPHIEUDX))
                {
                    pdx.RemoveAt(i);
                }
            }
            return pdx;
        }
        public void addCTNHTS(string tmp, PHIEUNHAPHANGTRUSO PN, TAIKHOAN TK)
        {
            db = new CMART8Entities();
            var ctpdx =db.CTPHIEUDEXUATs.Where(x => x.SOPHIEU.Equals(tmp)).ToList();
            foreach (var item in ctpdx)
            {
                CTPHIEUNHAPHANGTRUSO nhts = new CTPHIEUNHAPHANGTRUSO();
                nhts.SOPHIEUNHTS = PN.SOPHIEU;
                nhts.MASP = item.MASP;
                nhts.SOLUONG = item.SOLUONG;
                nhts.GIANHAP = 0;
                nhts.HANSD = DateTime.Now.AddMonths(6);
                nhts.TINHTRANG = "Đủ";
                db.CTPHIEUNHAPHANGTRUSOes.Add(nhts);
                db.SaveChanges();
            }
        }
        public PHIEUNHAPHANGTRUSO createNHTS(string matk)
        {

                db = new CMART8Entities();
                string id = autoID();
                PHIEUNHAPHANGTRUSO nhts = new PHIEUNHAPHANGTRUSO();
                nhts.SOPHIEU = id;
                nhts.MATK = matk;
                nhts.NGAYNHAP = DateTime.Now;
                db.PHIEUNHAPHANGTRUSOes.Add(nhts);
                db.SaveChanges();
                return nhts;
        }
        public bool checkExit(string soPhieu)
        {
            db = new CMART8Entities();
            List<PHIEUNHAPHANGTRUSO> tmp = db.PHIEUNHAPHANGTRUSOes.Where(st => st.SOPHIEUDX.Equals(soPhieu)).ToList();
            if (tmp.Count != 0)
            {
                return false;
            }
            return true;
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
            List<PHIEUNHAPHANGTRUSO> hd = db.PHIEUNHAPHANGTRUSOes.Where(st => st.SOPHIEU.Substring(3, 6).Equals(yy + mm + dd)).ToList();
            hd = db.PHIEUNHAPHANGTRUSOes.ToList().Where(h => h.SOPHIEU.Contains(yy + mm + dd)).ToList();
            if (hd.Count == 0)
            {
                s = "TS-" + yy + mm.Substring(mm.Length - 2, 2) + dd.Substring(dd.Length - 2, 2) + "-0001";
            }
            else
            {
                //var max = db.HOADONs.Where(st=> st.SOHD.Substring(3,6).Equals(yy+mm+dd)).Max(x=>x.SOHD.Substring(10,4));
                //HOADON tmp =db.HOADONs.First(x=>x.SOHD == max);
                string mahd = "000" + hd.Select(h => h.SOPHIEU.Substring(10)).OrderBy(so => so).Last();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                int ma = int.Parse(mahd) + 1;
                mahd = "000" + ma.ToString();
                mahd = mahd.Substring(mahd.Length - 4, 4);
                //HOADON tmp = hd.First();
                //int ma = Convert.ToInt32(tmp.SOHD.Substring(10, 4))+1;
                //int ma = int.Parse(tmp.SOHD.Substring(10, 4))+1;

                s = "TS-" + yy + mm + dd + "-" + mahd;
            }
            return s;
        }
    }
}
