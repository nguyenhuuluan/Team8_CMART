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
    public partial class GUI_LoaiSanPham : Form
    {
        BUS_LoaiSanPham ctl;
        ValidationExtension vl;
        int flag = 0;
        public GUI_LoaiSanPham()
        {
            ctl = new BUS_LoaiSanPham();
            vl = new ValidationExtension();
            InitializeComponent();
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
            lstLSP.Click += lstLSP_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (vl.Required(txtTenLSP.Text)  && vl.Required(txtSoLuong.Text))
            {
                string id = (string)lstLSP.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.checkExist(id) == false)
                    {
                        if (ctl.deleteLSP(id))
                        {
                            MessageBox.Show("Xóa Loại sản phẩm thành công!");
                            controlFunction("enableAll");
                            GUI_LoaiSanPham_Load(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Loại sản phẩm cần xóa không tồn tại trong hệ thống!");
                    }
                }
            }
            else {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm cần xóa!");
            }
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstLSP.DataSource = ctl.searchListLSP(txtSearch.Text);

        }

        void lstLSP_Click(object sender, EventArgs e)
        {
            txtTenLSP.Text = lstLSP.SelectedRows[0].Cells[1].Value.ToString();
            if (flag == 1)
            {
                txtSoLuong.Text = "0";
            }
            else
            {
                txtSoLuong.Text = lstLSP.SelectedRows[0].Cells[2].Value.ToString();
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            //Add Loại sản phẩm
            if (flag == 1)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTenLSP.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập tên loại sản phẩm!\n";
                    flg = false;
                }
                if (flg)
                {
                    if (ctl.checkExist(txtTenLSP.Text))
                    {
                        if (ctl.addLSP(txtTenLSP.Text))
                        {
                            MessageBox.Show("Thêm mới Loại sản phẩm thành công!");
                            GUI_LoaiSanPham_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới Loại sản phẩm không thành công");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên loại sản phẩm này đã tồn tại");
                    }
                }
                else {
                    MessageBox.Show(sTmp);
                }
            }
            //Edit Loại sản phẩm
            if (flag == 2)
            {
                 string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTenLSP.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập tên loại sản phẩm!\n";
                    flg = false;
                }
                if (flg)
                {
                    string id = (string)lstLSP.SelectedRows[0].Cells[0].Value;
                    if (ctl.checkExist(txtTenLSP.Text) || txtTenLSP.Text.Contains((string)lstLSP.SelectedRows[0].Cells[1].Value))
                    {
                        if (ctl.editLSP(id, txtTenLSP.Text))
                        {
                            MessageBox.Show("Cập nhật Loại sản phẩm thành công!");
                            GUI_LoaiSanPham_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Loại sản phẩm không thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên Loại Sản phẩm đã tồn tại!");
                    }
                }
                else {
                    MessageBox.Show(sTmp);
                }
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            controlFunction("enableAll");
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenLSP.Text != "")
            {
                txtSearch.Enabled = false;
                controlFunction("enableEdit");
                flag = 2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Loại sản phẩm cần cập nhật!");
            }
            
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
            flag = 1;
            txtTenLSP.Text = "";
            txtSoLuong.Text= "0";
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
                GUI_LoaiSanPham_Load(null, null);
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
                txtTenLSP.Enabled = false;
                txtSoLuong.Enabled = false;
                txtTenLSP.Text = "";
                txtSoLuong.Text = "";
                lstLSP.Enabled = true;
                txtSearch.Enabled = true;
                flag = 0;
            }
            if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtTenLSP.Enabled = true;
            }
        }

        private void GUI_LoaiSanPham_Load(object sender, EventArgs e)
        {
            lstLSP.DataSource = ctl.loadListLSP();
            lstLSP.Columns[3].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void formSanPham_Click(object sender, EventArgs e)
        {
            GUI_SanPham sp = new GUI_SanPham();
            this.Hide();
            sp.ShowDialog();
            this.Show();
        }

        private void formNCC_Click(object sender, EventArgs e)
        {
            GUI_NhaCungCap ncc = new GUI_NhaCungCap();
            this.Hide();
            ncc.ShowDialog();
            this.Show();
        }

        private void formTTKM_Click(object sender, EventArgs e)
        {
            GUI_TTKM ttkm = new GUI_TTKM();
            this.Hide();
            ttkm.ShowDialog();
            this.Show();
        }

        private void formLSG_Click(object sender, EventArgs e)
        {
            GUI_LichSuGia lsg = new GUI_LichSuGia();
            this.Hide();
            lsg.ShowDialog();
            this.Show();
        }
    }
}
