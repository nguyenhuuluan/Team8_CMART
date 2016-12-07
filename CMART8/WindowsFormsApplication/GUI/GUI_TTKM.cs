using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using System.Globalization;
namespace WindowsFormsApplication
{
    public partial class GUI_TTKM : Form
    {
        BUS_TTKM ctl = new BUS_TTKM();
        BUS_SanPham ctlSP = new BUS_SanPham();
        CMART8Entities db = new CMART8Entities();
        int flag = 0;
        public GUI_TTKM()
        {
            InitializeComponent();
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
            if (cboSP.Text != "" && txtNoiDung.Text != "" && txtGiaKM.Text != "" && txtHinhAnh.Text != "")
            {
                string id = (string)lstTTKM.SelectedRows[0].Cells[0].Value;
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.checkExist(id) == false)
                    {
                        if (ctl.deleteTTKM(id))
                        {
                            MessageBox.Show("Xóa Sản phẩm thành công!");
                            GUI_TTKM_Load(null, null);
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
                try
                {
                    SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                    //CultureInfo enUS = CultureInfo.CreateSpecificCulture("en-US");
                    //DateTimeFormatInfo dtfi = enUS.DateTimeFormat;
                    //string sTMp = txtNgayBD.Value.ToString("d", enUS);
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
            if (flag == 2)
            {
                try
                {
                    SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                    string id = (string)lstTTKM.SelectedRows[0].Cells[0].Value;

                        if (ctl.editTTKM(id, sp.MASP, float.Parse(txtGiaKM.Text),txtNgayBD.Value, txtNgayKT.Value, txtNoiDung.Text, txtHinhAnh.Text))
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

        private void GUI_TTKM_Load(object sender, EventArgs e)
        {
            lstTTKM.DataSource = ctl.loadListTTKM();
            lstTTKM.Columns[7].Visible = false;
            cboSP.DataSource = ctlSP.loadListSP();
            cboSP.DisplayMember = "TENSP";
            cboSP.ValueMember = "MASP";
        }

        private void cboSP_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sp = (SANPHAM)cboSP.SelectedItem;
                LICHSUGIA lsg = db.LICHSUGIAs.Single(st => st.MASP.Equals(sp.MASP));
                txtGiaKM.Text = lsg.GIABAN.ToString();
            }
            catch (Exception)
            { MessageBox.Show("Sản phẩm này hiện tại chưa có giá bán!"); }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }
    }
}
