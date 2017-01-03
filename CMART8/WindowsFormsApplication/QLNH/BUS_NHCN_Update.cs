using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8.QLNH
{
    class BUS_NHCN_Update
    {
        CMART8Entities db = new CMART8Entities();
        public List<CTPHIEUNHAPHANGCHINHANH> loadListCTNHCN(PHIEUNHAPHANGCHINHANH PN)
        {
            db = new CMART8Entities();
            return db.CTPHIEUNHAPHANGCHINHANHs.Where(x => x.SOPHIEUNHCN.Equals(PN.SOPHIEU)).ToList();
        }

        //Load combobox
        public List<PHIEUNHAPHANGTRUSO> loadListPTS(PHIEUNHAPHANGCHINHANH PN)
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
            pdx.Add(db.PHIEUNHAPHANGTRUSOes.Single(st => st.SOPHIEU.Equals(PN.SOPHIEUNHTS)));
            return pdx;
        }
        //Kiểm tra số phiếu trụ sở đó đã có phiếu nhập tai chi nhanhs nào chưa
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
        public bool updatePNHCN(PHIEUNHAPHANGCHINHANH PN, string sophieuTS, string chinhanh, DateTime ngay)
        {
            try
            {
                db = new CMART8Entities();
                PHIEUNHAPHANGCHINHANH pn = db.PHIEUNHAPHANGCHINHANHs.Find(PN.SOPHIEU);
                pn.SOPHIEUNHTS = sophieuTS;
                pn.CHINHANH = chinhanh;
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

        public bool updateListCTCN(List<CTPHIEUNHAPHANGCHINHANH> list, PHIEUNHAPHANGCHINHANH PN)
        {
            db = new CMART8Entities();
            try
            {
                List<CTPHIEUNHAPHANGCHINHANH> tmp = db.CTPHIEUNHAPHANGCHINHANHs.Where(st => st.SOPHIEUNHCN.Equals(PN.SOPHIEU)).ToList();
                foreach (CTPHIEUNHAPHANGCHINHANH it in tmp)
                {
                    db.CTPHIEUNHAPHANGCHINHANHs.Remove(it);
                    db.SaveChanges();
                }
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
    }
}
