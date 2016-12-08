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
    public partial class GUI_QLTK : Form
    {
        int flag = 0;
        BUS_QLTK ctl;
        ValidationExtension vl;
        public GUI_QLTK()
        {
            ctl = new BUS_QLTK();
            vl = new ValidationExtension();
            InitializeComponent();
            btnSearch.Click += btnSearch_Click;
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnDelete.Click += btnDelete_Click;
            lstTK.Click += lstTK_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            controlFunction("enableAll");
            cboQuyen.SelectedIndex = 0;
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            controlFunction("enableAll");
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            //Add 
            if (flag == 1)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTen.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Họ tên!\n";
                    flg = false;
                }
                if (!vl.Required(txtDiaChi.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Địa chỉ!\n";
                    flg = false;
                }
                if (!vl.Required(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số điện thoại!\n";
                    flg = false;
                } else if (!vl.checkNumber(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập lại đúng Số điện thoại!\n";
                    flg = false;
                }
                if (!vl.Required(txtTDN.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Tên đăng nhập!\n";
                    flg = false;
                }
                if (!vl.Required(txtMK.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Mật khẩu!\n";
                    flg = false;
                }
                else if (!vl.PassWordType(txtMK))
                {
                    sTmp = sTmp + "Mật khẩu phải từ 6-15 ký tự và không chứa kí tự đặc biệt!\n";
                    flg = false;
                }   
                if (!vl.Required(txtCMND.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số CMND!\n";
                    flg = false;
                }
                
                else if (!vl.checkNumber(txtCMND.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập lại đúng Số CMND!\n";
                    flg = false;
                }
                if (flg)
                {
                    if(ctl.addTK(txtTen.Text,txtDiaChi.Text,txtSDT.Text,txtCMND.Text,txtTDN.Text,txtMK.Text,cboQuyen.Text))
                    {
                        MessageBox.Show("Thêm mới tài khoản thành công!");
                        GUI_QLTK_Load(null, null);
                        controlFunction("enableAll");
                    }
                    else
                    {
                        MessageBox.Show("Thêm mới sản phẩm không thành công!");
                    }
                }
                else {

                    MessageBox.Show(sTmp);
                }
            }
            //Edit
            if (flag == 2)
            { 
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTen.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Họ tên!\n";
                    flg = false;
                }
                if (!vl.Required(txtDiaChi.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Địa chỉ!\n";
                    flg = false;
                }
                if (!vl.Required(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số điện thoại!\n";
                    flg = false;
                } else if (!vl.checkNumber(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập lại đúng Số điện thoại!\n";
                    flg = false;
                }
                if (!vl.Required(txtTDN.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Tên đăng nhập!\n";
                    flg = false;
                }
                if (!vl.Required(txtCMND.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số CMND!\n";
                    flg = false;
                }
                
                else if (!vl.checkNumber(txtCMND.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập lại đúng Số CMND!\n";
                    flg = false;
                }
                if (flg)
                {
                    if (editMK.Checked)
                    {
                        string sTmp2 = "";
                        bool flg2 = true;
                        if (!vl.Required(txtMK.Text))
                        {
                            sTmp2 = sTmp2 + "Vui lòng nhập mật khẩu!\n";
                            flg2 = false;
                        }
                        else if (!vl.PassWordType(txtMK))
                        {
                            sTmp2 = sTmp2 + "Mật khẩu phải từ 6-15 ký tự và không chứa kí tự đặc biệt!\n";
                            flg2 = false;
                        }
                        if (flg2)
                        {
                            if (ctl.editTK(lstTK.SelectedRows[0].Cells[0].Value.ToString(), txtTen.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, txtTDN.Text, txtMK.Text, cboQuyen.Text))
                            {
                                MessageBox.Show("Cập nhập thông tin tài khoản thành công!");
                                GUI_QLTK_Load(null, null);
                                controlFunction("enableAll");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhập thông tin tài khoản không thành công!");
                            }
                        }
                        else {
                            MessageBox.Show(sTmp2);
                        }
                    }
                    else
                    {
                        if (ctl.editTK(lstTK.SelectedRows[0].Cells[0].Value.ToString(), txtTen.Text, txtDiaChi.Text, txtSDT.Text, txtCMND.Text, txtTDN.Text, cboQuyen.Text))
                        {
                            MessageBox.Show("Cập nhập thông tin tài khoản thành công!");
                            GUI_QLTK_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhập thông tin tài khoản không thành công!");
                        }
                    }
                }
                else {
                    MessageBox.Show(sTmp);
                }
            }
        }

        void lstTK_Click(object sender, EventArgs e)
        {
            txtTen.Text = lstTK.SelectedRows[0].Cells[1].Value.ToString();
            txtDiaChi.Text = lstTK.SelectedRows[0].Cells[2].Value.ToString();
            txtSDT.Text = lstTK.SelectedRows[0].Cells[3].Value.ToString();
            txtCMND.Text = lstTK.SelectedRows[0].Cells[4].Value.ToString();
            txtTDN.Text = lstTK.SelectedRows[0].Cells[5].Value.ToString();
            cboQuyen.Text = lstTK.SelectedRows[0].Cells[7].Value.ToString();
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (vl.Required(txtTen.Text) && vl.Required(txtDiaChi.Text) && vl.Required(txtSDT.Text) && vl.Required(txtCMND.Text) && vl.Required(txtTDN.Text))
            {
                string id = (string)lstTK.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deleteTK(id))
                    {
                        MessageBox.Show("Xóa tài khoản thành công!");
                        GUI_QLTK_Load(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Xóa tài khoản không thành công!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần xóa!");
            }
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (vl.Required(txtTen.Text) && vl.Required(txtDiaChi.Text) && vl.Required(txtSDT.Text) && vl.Required(txtCMND.Text) && vl.Required(txtTDN.Text))
            {
                controlFunction("enableEdit");
                flag = 2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn tài khoản cần chỉnh sửa thông tin!");
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
            txtTen.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            txtCMND.Text = "";
            txtTDN.Text = "";
            txtMK.Text = "";
            flag = 1;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstTK.DataSource = ctl.searchListTK(txtSearch.Text);
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
                GUI_QLTK_Load(null, null);
            }
        }

        private void GUI_QLTK_Load(object sender, EventArgs e)
        {
            lstTK.DataSource = ctl.loadListTK();
            lstTK.Columns[6].Visible = false;
            lstTK.Columns[8].Visible = false;
            lstTK.Columns[9].Visible = false;
            lstTK.Columns[10].Visible = false;

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
                txtTen.Enabled = false;
                txtDiaChi.Enabled = false;
                txtSDT.Enabled = false;
                txtCMND.Enabled = false;
                txtTDN.Enabled = false;
                txtMK.Enabled = false;
                cboQuyen.Enabled = false;
                editMK.Hide();
                flag = 0;
                txtTen.Text = "";
                txtDiaChi.Text = "";
                txtSDT.Text = "";
                txtCMND.Text = "";
                txtTDN.Text = "";
                txtMK.Text = "";
                lstTK.Enabled = true;
            }
            if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtTen.Enabled = true;
                txtDiaChi.Enabled = true;
                txtSDT.Enabled = true;
                txtCMND.Enabled = true;
                txtTDN.Enabled = true;
                cboQuyen.Enabled = true;
                if (sTmp.Equals("enableEdit"))
                {
                    editMK.Show();
                    lstTK.Enabled = false;
                }
                else {
                    txtMK.Enabled = true;
                }
            }
        }

        private void editMK_CheckedChanged(object sender, EventArgs e)
        {
            if (editMK.Checked)
            {
                txtMK.Enabled = true;
            }
            else {
                txtMK.Enabled = false;
            }
        }

    }
}
