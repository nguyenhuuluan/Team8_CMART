using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8.QLNH
{
    class BUS_NHTS_Update
    {
        CMART8Entities db;
        public List<CTPHIEUNHAPHANGTRUSO> loadListCTNHTS(PHIEUNHAPHANGTRUSO PN)
        {
            db = new CMART8Entities();
            return db.CTPHIEUNHAPHANGTRUSOes.Where(x => x.SOPHIEUNHTS.Equals(PN.SOPHIEU)).ToList();
        }

        //Load combobox
        public List<PHIEUDEXUAT> loadListPDX(PHIEUNHAPHANGTRUSO PN)
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
            pdx.Add(db.PHIEUDEXUATs.Single(st => st.SOPHIEUDX.Equals(PN.SOPHIEUDX)));
            return pdx;
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
        //Cập nhật chi tiết nhập hàng trụ sở
        public bool updateListCTTS(List<CTPHIEUNHAPHANGTRUSO> list, PHIEUNHAPHANGTRUSO PN)
        {
            db = new CMART8Entities();
            try
            {
                List<CTPHIEUNHAPHANGTRUSO> tmp = db.CTPHIEUNHAPHANGTRUSOes.Where(st => st.SOPHIEUNHTS.Equals(PN.SOPHIEU)).ToList();
                foreach(CTPHIEUNHAPHANGTRUSO it in tmp)
                {
                    db.CTPHIEUNHAPHANGTRUSOes.Remove(it);
                    db.SaveChanges();
                }
                db = new CMART8Entities();
                foreach (CTPHIEUNHAPHANGTRUSO item in list)
                {
                    db.CTPHIEUNHAPHANGTRUSOes.Add(item);
                }
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool updatePNHTS(PHIEUNHAPHANGTRUSO PN, string sophieudx, string tongtien, string maTK, DateTime ngay)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGTRUSO pn = db.PHIEUNHAPHANGTRUSOes.Find(PN.SOPHIEU);
                pn.SOPHIEUDX = sophieudx;
                pn.TONGTIEN = ulong.Parse(tongtien);
                pn.MATK = maTK;
                pn.NGAYNHAP = ngay;
                db.Entry(pn).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}
