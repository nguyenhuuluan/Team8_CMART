using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.Dexuat
{
    public partial class RP_DX : Form
    {
        string soPhieu;
        CMART8Entities db;
        public RP_DX(string sophieu)
        {
            soPhieu = sophieu;
            db = new CMART8Entities();
            InitializeComponent();
        }

        private void RP_DX_Load(object sender, EventArgs e)
        {
            List<SP_CHITIETPHIEUDEXUAT_Result> tmp = db.SP_CHITIETPHIEUDEXUAT(soPhieu).ToList();
            BindingSource bs = new BindingSource();
            bs.DataSource = tmp;
            DX_RP rp = new DX_RP();
            rp.SetDataSource(bs);
            crv.ReportSource = rp;
            crv.RefreshReport(); 
        }
    }
}
