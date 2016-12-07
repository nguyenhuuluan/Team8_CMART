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
    public partial class GUI_SanPham : Form
    {
        BUS_NhaCungCap ctlNCC = new BUS_NhaCungCap();
        BUS_SanPham ctl = new BUS_SanPham();
        BUS_LoaiSanPham ctlLSP = new BUS_LoaiSanPham();
        CMART8Entities db = new CMART8Entities();
        int flag = 0;
        public GUI_SanPham()
        {
            InitializeComponent();
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
            btnSearch.Click += btnSearch_Click;
            btnDelete.Click += btnDelete_Click;
            lstSP.Click += lstSP_Click;
        }

        void lstSP_Click(object sender, EventArgs e)
        {
            txtTenSP.Text = (string)lstSP.SelectedRows[0].Cells[1].Value;
            txtHinhAnh.Text = (string)lstSP.SelectedRows[0].Cells[2].Value;
            string IDNCC = (string)lstSP.SelectedRows[0].Cells[4].Value;
            NHACUNGCAP ncc = db.NHACUNGCAPs.Single(st => st.MANCC.Equals(IDNCC));
            cbNCC.Text = ncc.TENNCC;
            string IDLSP = (string)lstSP.SelectedRows[0].Cells[3].Value;
            LOAISANPHAM lsp = db.LOAISANPHAMs.Single(st => st.MALOAI.Equals(IDLSP));
            cboLSP.Text = lsp.TENLOAI;

        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtTenSP.Text != "" && cboLSP.Text != "" && cbNCC.Text != "" && txtHinhAnh.Text != "")
            {
                string id = (string)lstSP.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.checkExist(id) == false)
                    {
                        if (ctl.deleteSP(id))
                        {
                            MessageBox.Show("Xóa Sản phẩm thành công!");
                            GUI_SanPham_Load(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sản phẩm cần xóa không tồn tại trong hệ thống!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Sản phẩm cần Xóa!");
            }
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstSP.DataSource = ctl.searchListSP(txtSearch.Text);
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            //add SANPHAM
            if (flag == 1)
            {
                try
                {
                    NHACUNGCAP ncc = (NHACUNGCAP)cbNCC.SelectedItem;
                    LOAISANPHAM lsp = (LOAISANPHAM)cboLSP.SelectedItem;
                    if (ctl.checkExist(txtTenSP.Text))
                    {
                        if (ctl.addSP(txtTenSP.Text,txtHinhAnh.Text,lsp.MALOAI,ncc.MANCC))
                        {
                            MessageBox.Show("Thêm mới Sản phẩm thành công!");
                            GUI_SanPham_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới Sản phẩm không thành công!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Tên Sản phẩm này đã tồn tại!");
                    }
                }
                catch (Exception)
                { MessageBox.Show("Chọn lại đúng Sản phẩm hoặc loại sản phẩm!"); }
            }
            //Edit SANPHAM
            if (flag == 2)
            {
                try
                {
                    NHACUNGCAP ncc = (NHACUNGCAP)cbNCC.SelectedItem;
                    LOAISANPHAM lsp = (LOAISANPHAM)cboLSP.SelectedItem;
                    string id = (string)lstSP.SelectedRows[0].Cells[0].Value;
                    if (ctl.checkExist(txtTenSP.Text) || txtTenSP.Text.Contains((string)lstSP.SelectedRows[0].Cells[1].Value))
                    {
                        if (ctl.editSP(id, txtTenSP.Text,txtHinhAnh.Text, lsp.MALOAI, ncc.MANCC))
                        {
                            MessageBox.Show("Cập nhật Sản phẩm thành công!");
                            GUI_SanPham_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Sản phẩm không thành công!");
                        }
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhập lại đúng Nhà cung cấp/Loại sản phẩm");
                }
            }
        }

        void btnCancel_Click(object sender, EventArgs e)
        {
            controlFunction("enableAll");
        }

        void btnEdit_Click(object sender, EventArgs e)
        {

            if (txtTenSP.Text != "" && cbNCC.Text != "" && cboLSP.Text != "")
            {
                txtSearch.Enabled = false;
                controlFunction("enableEdit");
                flag = 2;
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Sản phảm cần cập nhật!");
            }
        }

        void btnAdd_Click(object sender, EventArgs e)
        {
            controlFunction("enableAdd");
            flag = 1;
            txtTenSP.Text = "";
            txtHinhAnh.Text = "";
            cbNCC.Text = "";
            cboLSP.Text = "";
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
                GUI_SanPham_Load(null, null);
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
                txtHinhAnh.Enabled = false;
                txtTenSP.Enabled = false;
                cboLSP.Enabled = false;
                cbNCC.Enabled = false;
                lstSP.Enabled = true;
                txtSearch.Enabled = true;
                flag = 0;
                txtTenSP.Text = "";
                txtHinhAnh.Text = "";
                cboLSP.Text = "";
                cbNCC.Text = "";
            }
            if (sTmp.Equals("enableAdd")||sTmp.Equals("enableEdit"))
            {
                btnAdd.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                txtHinhAnh.Enabled = true;
                txtTenSP.Enabled = true;
                cboLSP.Enabled = true;
                cbNCC.Enabled = true;
                lstSP.Enabled = false;
                
            }
        }

        private void GUI_SanPham_Load(object sender, EventArgs e)
        {
            lstSP.DataSource = ctl.loadListSP();
            lstSP.Columns[5].Visible = false;
            lstSP.Columns[6].Visible = false;
            lstSP.Columns[7].Visible = false;
            lstSP.Columns[8].Visible = false;
            lstSP.Columns[9].Visible = false;
            lstSP.Columns[10].Visible = false;
            lstSP.Columns[11].Visible = false;
            cbNCC.DataSource = ctlNCC.loadListNCC();
            cbNCC.DisplayMember = "TENNCC";
            cbNCC.ValueMember = "MANCC";
            cboLSP.DataSource = ctlLSP.loadListLSP();
            cboLSP.DisplayMember = "TENLOAI";
            cboLSP.ValueMember = "MALOAI";
        }

    }
}
