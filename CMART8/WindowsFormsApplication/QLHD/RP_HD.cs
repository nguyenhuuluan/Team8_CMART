using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.QLHD
{
    public partial class RP_HD : Form
    {
        CMART8Entities db;
        string SoHD;
        public RP_HD(string soHD)
        {
            db = new CMART8Entities();
            SoHD = soHD;
            InitializeComponent();
        }
        private void RP_HD_Load(object sender, EventArgs e)
        {
            List<SP_CHITIETHOADON_Result> tmp = db.SP_CHITIETHOADON(SoHD).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = tmp;
            CTHD_RP rp = new CTHD_RP();
            rp.SetDataSource(bs);
            crv.ReportSource = rp;
            crv.RefreshReport(); 

        }

        private void RP_HD_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
