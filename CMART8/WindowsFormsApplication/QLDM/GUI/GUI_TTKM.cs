using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Globalization;
namespace CMART8
{
    public partial class GUI_TTKM : Form
    {
        BUS_TTKM ctl;
        BUS_SanPham ctlSP;
        CMART8Entities db;
        ValidationExtension vl;
        int flag = 0;
        TAIKHOAN TK;
        public GUI_TTKM(TAIKHOAN tmp)
        {
            TK = tmp;
            ctl = new BUS_TTKM();
            ctlSP = new BUS_SanPham();
            db = new CMART8Entities();
            vl = new ValidationExtension();
            InitializeComponent();
            controlFunction(TK.QUYEN);
            controlFunction("enableAll");
            btnAdd.Click += btnAdd_Click;
            btnEdit.Click += btnEdit_Click;
            btnCancel.Click += btnCancel_Click;
            btnSave.Click += btnSave_Click;
            lstTTKM.Click += lstTTKM_Click;
            btnDelete.Click += btnDelete_Click;
            btnSearch.Click += btnSearch_Click;
        }

        void btnSearch_Click(object sender, EventArgs e)
        {
            lstTTKM.DataSource = ctl.searchListTTKM(txtSearch.Text);
        }

        void btnDelete_Click(object sender, EventArgs e)
        {
            if (vl.Required(cboSP.Text)&& vl.Required(txtNoiDung.Text) && vl.Required(txtGiaKM.Text) && vl.Required(txtHinhAnh.Text))
            {
                string id = (string)lstTTKM.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.checkExist(id) == false)
                    {
                        if (ctl.deleteTTKM(id))
                        {
                            MessageBox.Show("Xóa thông tin khuyến mãi thành công!");
                            GUI_TTKM_Load(null, null);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thông tin khuyến mãi cần xóa không tồn tại trong hệ thống!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn Thông tin khuyến mãi cần Xóa!");
            }
        }

        void lstTTKM_Click(object sender, EventArgs e)
        {
            string tmp = lstTTKM.SelectedRows[0].Cells[1].Value.ToString();
            SANPHAM sp = db.SANPHAMs.Single(st=>st.MASP.Equals(tmp));
            cboSP.Text = sp.TENSP;
            txtGiaKM.Text = lstTTKM.SelectedRows[0].Cells[2].Value.ToString();
            txtNoiDung.Text = lstTTKM.SelectedRows[0].Cells[5].Value.ToString();
            txtHinhAnh.Text = lstTTKM.SelectedRows[0].Cells[6].Value.ToString();
            txtNgayBD.Text = lstTTKM.SelectedRows[0].Cells[3].Value.ToString();
            txtNgayKT.Text = lstTTKM.SelectedRows[0].Cells[4].Value.ToString();
        }

        void btnSave_Click(object sender, EventArgs e)
        {
            //add TTKM
            if (flag == 1)
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.Required(cboSP.Text))
                {
                    sTmp = sTmp + "Vui lòng chọn Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                 if (!vl.Required(txtGiaKM.Text))
                {
                    sTmp = sTmp + "Vui lòng chọn Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (!vl.Required(txtHinhAnh.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập hình ảnh Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if(!vl.Range(txtGiaKM, 0, double.Parse(txtGiaBan.Text)))
                {
                    sTmp = sTmp + "Vui lòng nhập giá khuyến mãi lại cho đúng!\n";
                    flg = false;
                }
                if (!vl.Required(txtNoiDung.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập nội dung Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (!vl.checkNumber(txtGiaKM.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập đúng kiểu Giá cho sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if(!vl.dateTime(txtNgayBD.Value, txtNgayKT.Value))
                {
                    sTmp = sTmp + "Vui lòng nhập ngày kết thúc sau ngày bắt đầu!\n";
                    flg = false;
                }
                if (flg)
                {
                    try
                    {
                        SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                        if (ctl.addTTKM(sp.MASP, float.Parse(txtGiaKM.Text), txtNgayBD.Value, txtNgayKT.Value, txtNoiDung.Text, txtHinhAnh.Text))
                        {
                            MessageBox.Show("Thêm mới Thông tin khuyến mãi thành công!");
                            GUI_TTKM_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Thêm mới Sản phẩm không thành công!");
                        }
                    }
                    catch (Exception)
                    { MessageBox.Show("Chọn lại đúng Sản phẩm hoặc loại sản phẩm!"); }
                }
                else {
                    MessageBox.Show(sTmp);
                }
            }
            if (flag == 2)
            {
                 string sTmp = "";
                bool flg = true;
                if (!vl.Required(cboSP.Text))
                {
                    sTmp = sTmp + "Vui lòng chọn Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                 if (!vl.Required(txtGiaKM.Text))
                {
                    sTmp = sTmp + "Vui lòng chọn Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (!vl.Required(txtHinhAnh.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập hình ảnh Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (!vl.Required(txtNoiDung.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập nội dung Sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (!vl.checkNumber(txtGiaKM.Text))
                {
                    sTmp = sTmp + "Vui lòng nhập đúng kiểu Giá cho sản phẩm khuyến mãi!\n";
                    flg = false;
                }
                if (flg)
                {
                    try
                    {
                        SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                        string id = (string)lstTTKM.SelectedRows[0].Cells[0].Value;

                        if (ctl.editTTKM(id, sp.MASP, float.Parse(txtGiaKM.Text), txtNgayBD.Value, txtNgayKT.Value, txtNoiDung.Text, txtHinhAnh.Text))
                        {
                            MessageBox.Show("Cập nhật Thông tin khuyến mãi thành công!");
                            GUI_TTKM_Load(null, null);
                            controlFunction("enableAll");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật Thông tin khuyế mãi không thành công!");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Nhập lại đúng Sản phẩm có khuyến mãi");
                    }
                }
                else
                {
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
            if (cboSP.Text != "" && txtNoiDung.Text != "" && txtGiaKM.Text != "" && txtHinhAnh.Text != "")
            {
                lstTTKM.Enabled = false;
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
            cboSP.Text = "";
            txtGiaKM.Text = "";
            txtNoiDung.Text = "";
            txtHinhAnh.Text = "";
            txtNgayBD.Text = "";
            txtNgayKT.Text = "";

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
                    cboSP.Enabled = false;
                    txtGiaKM.Enabled = false;
                    txtNgayBD.Enabled = false;
                    txtNgayKT.Enabled = false;
                    txtNoiDung.Enabled = false;
                    flag = 0;
                    cboSP.Text = "";
                    txtGiaKM.Text = "";
                    txtNoiDung.Text = "";
                    txtHinhAnh.Text = "";
                    txtNgayBD.Text = "";
                    txtNgayKT.Text = "";
                    txtSearch.Enabled = true;
                    lstTTKM.Enabled = true;

                }
                if (sTmp.Equals("enableAdd") || sTmp.Equals("enableEdit"))
                {
                    btnAdd.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = false;
                    btnSave.Enabled = true;
                    btnCancel.Enabled = true;
                    txtHinhAnh.Enabled = true;
                    cboSP.Enabled = true;
                    txtGiaKM.Enabled = true;
                    txtNgayBD.Enabled = true;
                    txtNgayKT.Enabled = true;
                    txtNoiDung.Enabled = true;
                }
                if (sTmp.Equals("Giám đốc"))
                {
                    lblQuyen.Text = TK.QUYEN;
                    formQLHD.Visible = false;
                    formQLNH.Visible = false;
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
                GUI_TTKM_Load(null, null);
            }
        }

        private void GUI_TTKM_Load(object sender, EventArgs e)
        {
            lstTTKM.DataSource = ctl.loadListTTKM();
            lstTTKM.Columns[7].Visible = false;
            cboSP.DataSource = ctlSP.loadListSP();
            cboSP.DisplayMember = "TENSP";
            cboSP.ValueMember = "MASP";
            cboSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cboSP.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cboSP_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                LICHSUGIA lsg = db.LICHSUGIAs.Where(st => st.MASP.Equals(sp.MASP)).OrderBy(st=>st.NGAYHIEULUC).ToList().Last();
                txtGiaBan.Text = lsg.GIABAN.ToString();
            }
            catch (Exception)
            { MessageBox.Show("Sản phẩm này hiện tại chưa có giá bán!"); }
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

        private void quảnLýNhàToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GUI_NhaCungCap ncc = new GUI_NhaCungCap(TK);
            this.Hide();
            ncc.ShowDialog();
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
