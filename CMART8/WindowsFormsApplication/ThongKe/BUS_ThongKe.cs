using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMART8
{   
    class BUS_ThongKe
    {
        CMART8Entities db;
        public List<SP_THONGKEDOANHTHU_NGAY_Result> thongKeNgay(int ngay, int thang, int nam)
        {
            db = new CMART8Entities();
            return db.SP_THONGKEDOANHTHU_NGAY(ngay, thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_THANG_Result> thongKeThang(int thang, int nam)
        {
            db = new CMART8Entities();
            return db.SP_THONGKEDOANHTHU_THANG(thang, nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_NAM_Result> thongKeNam(int nam)
        {
            db = new CMART8Entities();
            return db.SP_THONGKEDOANHTHU_NAM(nam).ToList();
        }
        public List<SP_THONGKEDOANHTHU_TG_Result> thongKeTg(DateTime ngayBD, DateTime ngayKT)
        {
            db = new CMART8Entities();
            return db.SP_THONGKEDOANHTHU_TG(ngayBD, ngayKT).ToList();
        }

    }
}
