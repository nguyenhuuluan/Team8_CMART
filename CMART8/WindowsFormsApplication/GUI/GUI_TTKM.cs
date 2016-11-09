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
    public partial class GUI_TTKM : Form
    {
        public GUI_TTKM()
        {
            InitializeComponent();
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Success");
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
        private void controlFunction(string sTmp)
        {
                if (sTmp.Equals("enableAll"))
                {
                    btnAdd.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = true;
                    btnSave.Enabled = false;
                    btnCancel.Enabled = false;
                    txtHinhAnh.Enabled = false;
                    txtTenSP.Enabled = false;
                    txtGiaKM.Enabled = false;
                    txtNgayBD.Enabled = false;
                    txtNgayKT.Enabled = false;
                    txtNoiDung.Enabled = false;
                }
                if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
                {
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    txtHinhAnh.Enabled = true;
                    txtTenSP.Enabled = true;
                    txtGiaKM.Enabled = true;
                    txtNgayBD.Enabled = true;
                    txtNgayKT.Enabled = true;
                    txtNoiDung.Enabled = true;
                }
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
    }
}
