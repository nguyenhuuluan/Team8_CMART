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
    public partial class RP_NHCN : Form
    {
        string sophieu;
        CMART8Entities db;
        public RP_NHCN(string id)
        {
            db = new CMART8Entities();
            sophieu = id;
            InitializeComponent();
        }

        private void RP_NHCN_Load(object sender, EventArgs e)
        {
            List<SP_CHITIETPHIEUNHAPCHINHANH_Result> tmp = db.SP_CHITIETPHIEUNHAPCHINHANH(sophieu).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = tmp;
            NHCN_RP rp = new NHCN_RP();
            rp.SetDataSource(bs);
            crv.ReportSource = rp;
            crv.RefreshReport(); 
        }

        private void RP_NHCN_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
