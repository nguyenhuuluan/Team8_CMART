using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CMART8.QLHD;
namespace CMART8.QLHD
{
    public partial class GUI_QLHD : Form
    {
        CMART8Entities db;
        TAIKHOAN TK;
        BUS_QLHD ctl;
        string POS;
        public GUI_QLHD(TAIKHOAN tmp, string pos)
        {
            ctl = new BUS_QLHD();
            db = new CMART8Entities();
            TK = tmp;
            POS = pos;
            InitializeComponent();
            controlFunction(TK.QUYEN);
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Nhân viên bán hàng"))
            {
                lblPOS.Text = POS;
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLTK.Visible = false;
                formQLNH.Visible = false;
            }
        }

        private void GUI_QLHD_Load(object sender, EventArgs e)
        {
            lstHD.DataSource = ctl.loadListHD();
            lstHD.Columns[8].Visible = false;
            lstHD.Columns[9].Visible = false;

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstHD.DataSource = ctl.search(txtSearch.Text);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == txtSearch.Tag.ToString())
            {
                txtSearch.Text = null;
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = txtSearch.Tag.ToString();
                txtSearch.ForeColor = Color.Silver;
                GUI_QLHD_Load(null, null);
            }
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //ctl.createHD();
            //GUI_QLHD_Load(null, null);
            QLHD.GUI_CTHD ncc = new GUI_CTHD("Create", TK, ctl.createHD(lblPOS.Text, TK.MATK), POS);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = lstHD.SelectedRows[0].Cells[0].Value.ToString();
            HOADON hd = db.HOADONs.Single(st => st.SOHD.Equals(id));
            QLHD.GUI_CTHD ncc = new GUI_CTHD("Edit", TK, hd, POS);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
            //GUI_QLHD_Load(null, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lstHD.SelectedRows[0].Cells[0].Value.ToString();
            RP_HD form = new RP_HD(id);
            form.ShowDialog();
        }
    }
}
