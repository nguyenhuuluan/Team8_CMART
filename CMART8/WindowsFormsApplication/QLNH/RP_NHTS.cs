using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.QLNH
{
    public partial class RP_NHTS : Form
    {
        CMART8Entities db;
        string sophieu;
        public RP_NHTS(string id)
        {
            sophieu = id;
            db = new CMART8Entities();
            InitializeComponent();
        }

        private void RP_NHTS_Load(object sender, EventArgs e)
        {
            List<SP_CHITIETPHIEUNHAPTRUSO_Result> tmp = db.SP_CHITIETPHIEUNHAPTRUSO(sophieu).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = tmp;
            NHTS_RP rp = new NHTS_RP();
            rp.SetDataSource(bs);
            crv.ReportSource = rp;
            crv.RefreshReport(); 
        }

        private void RP_NHTS_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
