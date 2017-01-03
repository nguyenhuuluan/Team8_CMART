using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.ThongKe
{
    public partial class GUI_Report : Form
    {
        DateTime BD;
        DateTime KT;
        CMART8Entities db;
        string THk;
        public GUI_Report(DateTime ngayBD, DateTime ngayKT, string sTmp)
        {
            BD = ngayBD;
            KT = ngayKT;
            THk = sTmp;
            db = new CMART8Entities();
            InitializeComponent();
        }

        private void GUI_Report_Load(object sender, EventArgs e)
        {
            if (THk.Equals("Ngay"))
            {
                int ngay = int.Parse(BD.Day + "");
                int thang = int.Parse(BD.Month.ToString());
                int nam = int.Parse(BD.Year.ToString());
                List<SP_THONGKEDOANHTHU_NGAY_Result> tmp = db.SP_THONGKEDOANHTHU_NGAY(ngay, thang, nam).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = tmp;
                RP_TKNgay rp = new RP_TKNgay();
                rp.SetDataSource(bs);
                crv.ReportSource = rp;
                crv.RefreshReport(); 
            }
            else if (THk.Equals("Thang"))
            {
                int thang = int.Parse(BD.Month.ToString());
                int nam = int.Parse(BD.Year.ToString());
                List<SP_THONGKEDOANHTHU_THANG_Result> tmp = db.SP_THONGKEDOANHTHU_THANG(thang, nam).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = tmp;
                RP_TKThang rp = new RP_TKThang();
                rp.SetDataSource(bs);
                crv.ReportSource = rp;
                crv.RefreshReport();
            }
            else if (THk.Equals("Nam"))
            {
                int nam = int.Parse(BD.Year.ToString());
                List<SP_THONGKEDOANHTHU_NAM_Result> tmp = db.SP_THONGKEDOANHTHU_NAM(nam).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = tmp;
                RP_TKNam rp = new RP_TKNam();
                rp.SetDataSource(bs);
                crv.ReportSource = rp;
                crv.RefreshReport();
            }
            else if (THk.Equals("TG"))
            {
                List<SP_THONGKEDOANHTHU_TG_Result> tmp = db.SP_THONGKEDOANHTHU_TG(BD, KT).ToList();
                BindingSource bs = new BindingSource();
                bs.DataSource = tmp;
                RP_TKTG rp = new RP_TKTG();
                rp.SetDataSource(bs);
                crv.ReportSource = rp;
                crv.RefreshReport();
            }
        }

        private void GUI_Report_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
