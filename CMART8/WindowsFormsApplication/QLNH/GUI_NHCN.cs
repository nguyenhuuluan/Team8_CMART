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
    public partial class GUI_DX : Form
    {
        TAIKHOAN TK;
        BUS_NHCN ctl;
        CMART8Entities db;
        public GUI_DX(TAIKHOAN tmp)
        {
            db = new CMART8Entities();
            TK = tmp;
            ctl = new BUS_NHCN();
            InitializeComponent();
            controlFunction(TK.QUYEN);
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Quản lý chi nhánh"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLHD.Visible = false;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLTK.Visible = false;
                formNHTS.Visible = false;
            }
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
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
            lstNHCN.DataSource = ctl.search(txtSearch.Text);
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
                GUI_NHCN_Load(null, null);
            }
        }

        private void GUI_NHCN_Load(object sender, EventArgs e)
        {
            lstNHCN.DataSource = ctl.loadListNHCN();
            lstNHCN.Columns[5].Visible = false;
            lstNHCN.Columns[6].Visible = false;
            lstNHCN.Columns[7].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CTDX frm = new GUI_CTDX(ctl.createNHCN(TK), TK);
            this.Hide();
            frm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANGCHINHANH PN = db.PHIEUNHAPHANGCHINHANHs.Find(lstNHCN.SelectedRows[0].Cells[0].Value);
            GUI_CTDX_Update ts = new GUI_CTDX_Update(TK, PN);
            this.Hide();
            ts.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lstNHCN.SelectedRows[0].Cells[0].Value.ToString();
            RP_NHCN form = new RP_NHCN(id);
            form.ShowDialog();
        }
    }
}
