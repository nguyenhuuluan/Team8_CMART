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
    public partial class GUI_NHTS : Form
    {
        TAIKHOAN TK;
        BUS_NHTS ctl;
        CMART8Entities db;
        public GUI_NHTS(TAIKHOAN tmp)
        {
            ctl = new BUS_NHTS();
            TK = tmp;
            db = new CMART8Entities();
            InitializeComponent();
            controlFunction(TK.QUYEN);
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Nhân viên kiểm kho"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLHD.Visible = false;
                formQLTK.Visible = false;
                formNHCN.Visible = false;
            }
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }

        private void GUI_NHTS_Load(object sender, EventArgs e)
        {
            lstNHTS.DataSource = ctl.loadListNHTS();
            lstNHTS.Columns[5].Visible = false;
            lstNHTS.Columns[6].Visible = false;
            lstNHTS.Columns[7].Visible = false;
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
            lstNHTS.DataSource = ctl.search(txtSearch.Text);
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
                GUI_NHTS_Load(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            GUI_CTTS ts = new GUI_CTTS(TK, ctl.createNHTS(TK.MATK));
            this.Hide();
            ts.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PHIEUNHAPHANGTRUSO PN = db.PHIEUNHAPHANGTRUSOes.Find(lstNHTS.SelectedRows[0].Cells[0].Value);
            GUI_CTTS_Update ts = new GUI_CTTS_Update(TK, PN);
            this.Hide();
            ts.ShowDialog();
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = lstNHTS.SelectedRows[0].Cells[0].Value.ToString();
            RP_NHTS form = new RP_NHTS(id);
            form.ShowDialog();
        }

    }
}
