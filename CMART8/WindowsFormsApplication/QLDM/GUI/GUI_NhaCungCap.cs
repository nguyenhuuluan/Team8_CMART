using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace CMART8
{
    public partial class GUI_NhaCungCap : Form
    {
        BUS_NhaCungCap ctl;
        ValidationExtension vl;
        TAIKHOAN TK;
        int flag = 0;
        public GUI_NhaCungCap(TAIKHOAN tmp)
        {
            TK = tmp;
            ctl = new BUS_NhaCungCap();
            vl = new ValidationExtension();
            InitializeComponent();
            controlFunction(TK.QUYEN);
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnSave.Click += btnSave_Click;
            btnCancel.Click += btnCancel_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
            lstNCC.Click += lstNCC_Click;
        }

        void lstNCC_Click(object sender, EventArgs e)
        {
            txtTenNCC.Text = (string)lstNCC.SelectedRows[0].Cells[1].Value;
            txtDiaChi.Text = (string)lstNCC.SelectedRows[0].Cells[3].Value;
            txtSDT.Text = (string)lstNCC.SelectedRows[0].Cells[2].Value;
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (vl.Required(txtTenNCC.Text) && vl.Required(txtDiaChi.Text) && vl.Required(txtSDT.Text))
            {
                string id = (string)lstNCC.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.checkExist(id) == false)
                    {
                        if (ctl.deleteNCC(id))
                        {
                            MessageBox.Show("Xóa Nhà cung cấp thành công!");
                            GUI_NhaCungCap_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Hiện có sản phẩm thuộc nhà cung cấp này trong hệ thông!");   
                        }
                    }
                    else
                    {
                        MessageBox.Show("Nhà cung cấp cần xóa không tồn tại trong hệ thống!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp cần Xóa!");
            }
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstNCC.DataSource = ctl.searchListNCC(txtSearch.Text);

        }

        void btnSave_Click(object sender, EventArgs e)
        {
            //add NhaCungCap
            if (flag == 1)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTenNCC.Text))
                {
                    sTmp = sTmp+ "Vui lòng nhập tên Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.Required(txtDiaChi.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Địa chỉ Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.Required(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số điện thoại Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.checkNumber(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập đúng kiểu Số điện thoại!\n";
                    flg = false;
                }
                if (flg)
                {
                        if (ctl.checkExist(txtTenNCC.Text))
                        {
                            if (ctl.addNCC(txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text))
                            {
                                MessageBox.Show("Thêm mới Nhà cung cấp thành công!");
                                GUI_NhaCungCap_Load(null, null);
                                controlFunction("enableAll");
                            }
                            else
                            {
                                MessageBox.Show("Thêm mới Nhà cung cấp không thành công!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Tên Nhà cung cấp này đã tồn tại!");
                        }
                }
                else
                {
                    MessageBox.Show(sTmp);
                }
            }
            //Edit NhaCungCap
            if (flag == 2)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(txtTenNCC.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập tên Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.Required(txtDiaChi.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Địa chỉ Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.Required(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập Số điện thoại Nhà cung cấp!\n";
                        flg = false;
                }
                if (!vl.checkNumber(txtSDT.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập đúng kiểu Số điện thoại!\n";
                    flg = false;
                }
                if (flg)
                {
                        string id = (string)lstNCC.SelectedRows[0].Cells[0].Value;
                        if (ctl.checkExist(txtTenNCC.Text) || txtTenNCC.Text.Contains((string)lstNCC.SelectedRows[0].Cells[1].Value))
                        {
                            if (ctl.editNCC(id, txtTenNCC.Text, txtDiaChi.Text, txtSDT.Text))
                            {
                                MessageBox.Show("Cập nhật Nhà cung cấp thành công!");
                                GUI_NhaCungCap_Load(null, null);
                                controlFunction("enableAll");
                            }
                            else
                            {
                                MessageBox.Show("Cập nhật Nhà cung cấp không thành công!");
                            }
                        }
                }
                else
                { MessageBox.Show(sTmp); }
            }

        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            controlFunction("enableAll");
            flag = 0;
            GUI_NhaCungCap_Load(null, null);
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtTenNCC.Text != "" && txtDiaChi.Text != "" && txtSDT.Text != "")
            {
                controlFunction("enableEdit");
                flag = 2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Nhà cung cấp cần cập nhật!");
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
            flag = 1;
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
                GUI_NhaCungCap_Load(null, null);
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
                lstNCC.Enabled = true;
                flag = 0;
                txtTenNCC.Text = "";
                txtSDT.Text = "";
                txtDiaChi.Text = "";

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
                if (sTmp.Equals("enableEdit"))
                {
                  lstNCC.Enabled = false;
                }
            }
            if (sTmp.Equals("Giám đốc"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLHD.Visible = false;
                formQLNH.Visible = false;
            }

        }

        private void GUI_NhaCungCap_Load(object sender, EventArgs e)
        {
            lstNCC.DataSource = ctl.loadListNCC();
            lstNCC.Columns[4].Visible = false;
            lstNCC.Columns[5].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void quảnLýSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_SanPham sp = new GUI_SanPham(TK);
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }

        private void quảnLýLoạiSảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_LoaiSanPham lsp = new GUI_LoaiSanPham(TK);
            this.Hide();
            lsp.ShowDialog();
            this.Close();
        }

        private void thôngTinKhuyếnMãiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_TTKM ttkm = new GUI_TTKM(TK);
            this.Hide();
            ttkm.ShowDialog();
            this.Close();
        }

        private void formThongke_Click(object sender, EventArgs e)
        {
            GUI_Thongke tk = new GUI_Thongke(TK);
            this.Hide();
            tk.ShowDialog();
            this.Close();
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }

        private void formQLTK_Click(object sender, EventArgs e)
        {
            GUI_QLTK qltk = new GUI_QLTK(TK);
            this.Hide();
            qltk.ShowDialog();
            this.Close();
        }

        private void formLSG_Click(object sender, EventArgs e)
        {
            GUI_LichSuGia lsg = new GUI_LichSuGia(TK);
            this.Hide();
            lsg.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }
    }
}
