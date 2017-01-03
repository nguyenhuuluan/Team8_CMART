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
    public partial class GUI_LichSuGia : Form
    {
        BUS_LichSuGia ctl;
        BUS_SanPham ctlSP;
        CMART8Entities db;
        ValidationExtension vl;
        int flag = 0;
        TAIKHOAN TK;
        public GUI_LichSuGia(TAIKHOAN tmp)
        {
            TK = tmp;
            ctl = new BUS_LichSuGia();
            ctlSP = new BUS_SanPham();
            db =  new CMART8Entities();
            vl = new ValidationExtension();
            InitializeComponent();
            controlFunction(TK.QUYEN);
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            lstLSG.Click += lstLSG_Click;
            btnSearch.Click += btnSearch_Click;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
            btnDelete.Click += btnDelete_Click;
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (vl.Required(cboTenSP.Text) && vl.Required(txtGia.Text))
            {
                string id = lstLSG.SelectedRows[0].Cells[0].Value.ToString();
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                        if (ctl.deleteLSG(id,txtGia.Text,txtNgayHieuLuc.Value.ToString()))
                        {
                            MessageBox.Show("Xóa Lịch sử giá sản phẩm thành công!");
                            GUI_LichSuGia_Load(null, null);
                        }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Lịch sử giá sản phầm cần Xóa!");
            }
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(cboTenSP.Text))
                {
                    flg = false;
                    sTmp = sTmp + "Vui lòng chọn sản phẩm!\n";
                }
                if(!vl.Required(txtGia.Text))
                {
                    flg = false;
                    sTmp = sTmp +"Vui lòng nhập giá cho sản phẩm!\n";
                }
                if (!vl.MinValue(txtGia, 0))
                {
                    flg = false;
                    sTmp = sTmp + "Giá sản phẩm phải lơn 0!\n";
                }
                if (flg)
                {
                    try
                    {
                        SANPHAM sp = (SANPHAM)cboTenSP.SelectedItem;
                        if (ctl.addLSG(sp.MASP, txtGia.Text, txtNgayHieuLuc.Value))
                        {
                            MessageBox.Show("Thêm mới Lịch sử giá thành công!");
                            GUI_LichSuGia_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới Lịch sử giá không thành công!");
                        }
                    }
                    catch (Exception)
                    { MessageBox.Show("Vui lòng chọn lại đúng Sản phẩm!"); }
                }
                else {
                    MessageBox.Show(sTmp);
                }
            }
            if (flag == 2)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(cboTenSP.Text))
                {
                    flg = false;
                    sTmp = sTmp + "Vui lòng chọn sản phẩm!\n";
                }
                if (!vl.Required(txtGia.Text))
                {
                    flg = false;
                    sTmp = sTmp + "Vui lòng nhập giá cho sản phẩm!\n";
                }
                if (!vl.MinValue(txtGia, 0))
                {
                    flg = false;
                    sTmp = sTmp + "Giá sản phẩm phải lơn 0!\n";
                }

                if (flg)
                {
                    try
                    {
                        SANPHAM sp = (SANPHAM)cboTenSP.SelectedItem;
                        string id = lstLSG.SelectedRows[0].Cells[0].Value.ToString();
                        string gia = lstLSG.SelectedRows[0].Cells[1].Value.ToString();
                        string ngayhl = lstLSG.SelectedRows[0].Cells[2].Value.ToString();
                        DateTime ngayhl2 = txtNgayHieuLuc.Value;
                        string gia2 = txtGia.Text;
                        string id2 = cboTenSP.SelectedValue + "";
                        if (ctl.editLSG(id, gia, ngayhl, id2, gia2, ngayhl2))
                        {
                            MessageBox.Show("Cập nhật lịch sử giá thành công!");
                            controlFunction("enableAll");
                            GUI_LichSuGia_Load(null, null);
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật lịch sử giá không thành công!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Chọn lại đúng Sản phẩm");
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

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstLSG.DataSource = ctl.searchListLSG(txtSearch.Text);
        }

        void lstLSG_Click(object sender, EventArgs e)
        {
            txtGia.Text = lstLSG.SelectedRows[0].Cells[1].Value.ToString();
            txtNgayHieuLuc.Text = lstLSG.SelectedRows[0].Cells[2].Value.ToString();
            string id = lstLSG.SelectedRows[0].Cells[0].Value.ToString();
            SANPHAM sp = db.SANPHAMs.Single(st => st.MASP.Equals(id));
            cboTenSP.Text = sp.TENSP;
        }

        void btnEdit_Click(object sender, EventArgs e)
        {
            controlFunction("enableEdit");
            flag = 2;
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
            txtGia.Text = "";
            cboTenSP.Text = "";
            txtNgayHieuLuc.Text = "";
            flag = 1;
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
                GUI_LichSuGia_Load(null, null);
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
                cboTenSP.Enabled = false;
                txtGia.Enabled = false;
                txtNgayHieuLuc.Enabled = false;
                txtSearch.Enabled = true;
                flag = 0;
                txtNgayHieuLuc.Text = "";
                txtGia.Text = "";
                cboTenSP.Text = "";
                lstLSG.Enabled = true;
            }
            if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtNgayHieuLuc.Enabled = true;
                txtGia.Enabled = true;
                cboTenSP.Enabled = true;

                if(sTmp.Equals("enableEdit"))
                {
                    lstLSG.Enabled = false;
                }
            }
            if (sTmp.Equals("Giám đốc"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLHD.Visible = false;
                formQLNH.Visible = false;
            }
        }
        private void GUI_LichSuGia_Load(object sender, EventArgs e)
        {
            lstLSG.DataSource = ctl.loadListSP();
            cboTenSP.DataSource = ctlSP.loadListSP();
            cboTenSP.DisplayMember = "TENSP";
            cboTenSP.ValueMember = "MASP";
            cboTenSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboTenSP.AutoCompleteSource = AutoCompleteSource.ListItems;
            controlFunction("enableAll");
            lstLSG.Columns[3].Visible = false;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
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

        private void quảnLýNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCungCap ncc = new GUI_NhaCungCap(TK);
            this.Hide();
            ncc.ShowDialog();
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

        private void quảnLýSảnPhẩmToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GUI_SanPham sp = new GUI_SanPham(TK);
            this.Hide();
            sp.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click_1(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

    }
}
