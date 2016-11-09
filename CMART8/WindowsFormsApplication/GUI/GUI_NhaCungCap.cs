using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class GUI_NhaCungCap : Form
    {
        public GUI_NhaCungCap()
        {
            InitializeComponent();
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success!");
            controlFunction("enableAll");
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            controlFunction("enableAll");
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            controlFunction("enableEdit");
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == txtSearch.Tag.ToString())
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text.Trim() == "")
            {
                txtSearch.Text = txtSearch.Tag.ToString();
                txtSearch.ForeColor = Color.Silver;
            }
        }
        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("enableAll"))
            {
                btnAdd.Enabled = true;
                btnEdit.Enabled = true;
                btnDelete.Enabled = true;
                btnSave.Enabled = false;
                btnCancel.Enabled = false;
                txtTenNCC.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
            }
            if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtTenNCC.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
            }

        }

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            CMART8Entities db = new CMART8Entities();
            lstNCC.DataSource = db.NHACUNGCAPs.ToList();
        }
    }
}
