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
    public partial class GUI_DX : Form
    {
        BUS_DX ctl;
        TAIKHOAN TK;
        CMART8Entities db;
        public GUI_DX(TAIKHOAN tk)
        {
            TK = tk;
            db = new CMART8Entities();
            ctl = new BUS_DX();
            InitializeComponent();
            controlFunction(TK.QUYEN);
        }
        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Thư ký"))
            {
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLTK.Visible = false;
                formQLHD.Visible = false;
                formNHCN.Visible = false;
                formNHTS.Visible = false;
            }
        }
        private void GUI_DX_Load(object sender, EventArgs e)
        {
            lstDX.DataSource = ctl.loadlistPDX();
            lstDX.Columns[4].Visible = false;
            lstDX.Columns[5].Visible = false;
            lstDX.Columns[6].Visible = false;
            lstDX.Columns[7].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstDX.DataSource = ctl.searchPDX(txtSearch.Text);
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
                GUI_DX_Load(null, null);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHIEUDEXUAT PDX = db.PHIEUDEXUATs.Find(lstDX.SelectedRows[0].Cells[0].Value);
            GUI_CTDX ctdx = new GUI_CTDX(TK, PDX, "Edit");
            this.Hide();
            ctdx.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CTDX ctdx = new GUI_CTDX(TK, ctl.createPDX(TK.MATK), "Add");
            this.Hide();
            ctdx.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            RP_DX form = new RP_DX(lstDX.SelectedRows[0].Cells[0].Value.ToString());
            form.ShowDialog();
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }
    }
}
