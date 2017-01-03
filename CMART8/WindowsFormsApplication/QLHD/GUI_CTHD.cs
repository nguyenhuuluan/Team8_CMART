using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.QLHD
{
    public partial class GUI_CTHD : Form
    {
        TAIKHOAN TK;
        HOADON HD;
        CMART8Entities db;
        BUS_SanPham ctlSP;
        BUS_QLHD ctl;
        ValidationExtension vl;
        string GUI;
        string POS;
        public GUI_CTHD(string gui, TAIKHOAN tmp, HOADON tmp2, string pos)
        {
            TK = tmp;
            HD = tmp2;
            GUI = gui;
            POS = pos;
            ctlSP = new BUS_SanPham();
            ctl = new BUS_QLHD();
            db = new CMART8Entities();
            vl = new ValidationExtension();
            InitializeComponent();
            controlFunction(GUI);
            lstCTHD.Click += lstCTHD_Click;
        }

        void lstCTHD_Click(object sender, EventArgs e)
        {
            try
            {
                SANPHAM sp = db.SANPHAMs.Find(lstCTHD.SelectedRows[0].Cells[1].Value.ToString());
                txtTenSP.Text = sp.TENSP;
            }
            catch
            { }
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Create"))
            {
                btnHuy.Visible = true;
            }
            if (sTmp.Equals("Edit"))
            {
                btnSave.Text = "Lưu";
                btnCancel.Text = "Quay lại";
            }
        }

        private void GUI_CTHD_Load(object sender, EventArgs e)
        {
            txtNgBan.Text = db.TAIKHOANs.Where(st => st.MATK.Equals(HD.MATK)).ToList().Select(b => b.HOTEN).Last();
            txtNgay.Text = HD.NGAYBAN.ToString();
            txtTongTien.Text = HD.TONGTIEN.ToString();
            txtTSL.Text = HD.TONGSL.ToString();
            txtTienKH.Text = HD.TIENKHACHDUA.ToString();
            txtTienTra.Text = HD.TIENKHATRA.ToString();
            lstCTHD.DataSource = ctl.loadListCTHD(HD.SOHD);
            List<CTHOADON> cthd = ctl.loadListCTHD(HD.SOHD);
            List<HOADON> tmp = ctl.loadListHD();
            lstCTHD.DataSource = cthd.Select(b => new { MaHoaDon = b.SOHD, MaSP = b.MASP, Dongia = b.DONGIA, Soluong = b.SOLUONG, ThanhTien = b.SOLUONG * b.DONGIA }).ToList();
            txtTongTien.Text = cthd.Sum(st => st.SOLUONG * st.DONGIA).ToString();
            txtTSL.Text = cthd.Sum(st => st.SOLUONG).ToString();
            ctl.updateHD(HD.SOHD, txtTongTien.Text, txtTienKH.Text, txtTienTra.Text, txtTSL.Text);


        }

        private void txtMaSP_Leave(object sender, EventArgs e)
        {
            if (txtMaSP.Text != "")
            {
                try
                {
                    SANPHAM sp = db.SANPHAMs.Single(st => st.MASP.Equals(txtMaSP.Text));
                    LICHSUGIA lsg = db.LICHSUGIAs.Where(st => st.MASP.Equals(sp.MASP)).OrderBy(st => st.NGAYHIEULUC).ToList().Last();
                    txtGiaBan.Text = lsg.GIABAN.ToString();
                    txtTenSP.Text = sp.TENSP;
                }
                catch
                {
                    MessageBox.Show("Mã sản phẩm không tồn tại!");
                    txtMaSP.Text = "";
                }
            }
        }

        private void txtMaSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtMaSP_Leave(null, null);
            if (ctl.addSP(HD.SOHD, txtMaSP.Text, txtSL.Value.ToString(), txtGiaBan.Text))
            {
                MessageBox.Show("Thêm sản phẩm thành công!");
                txtMaSP.Text = "";
                GUI_CTHD_Load(null, null);
            }
            else
            {
                txtMaSP.Text = "";
                MessageBox.Show("Thêm sản phẩm thất bại!");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = (string)lstCTHD.SelectedRows[0].Cells[1].Value;
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (ctl.deleteSP(HD.SOHD, id))
                {
                    MessageBox.Show("Xóa sản phẩm thành công!");
                    GUI_CTHD_Load(null, null);
                    txtTienKH_Leave(null, null);
                }
                else
                {
                    MessageBox.Show("Xóa sản phẩm thất bại!");
                }
            }
        }

        private void txtSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (GUI.Equals("Edit"))
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.checkNumber(txtTienKH.Text))
                {
                    sTmp = sTmp + "Tiền phải là số!\n";
                    flg = false;
                }
                else if (!vl.MinValue(txtTienKH, ulong.Parse(txtTongTien.Text)))
                {
                    sTmp = sTmp + "Tiền khách đưa phải lớn hơn tổng tiền của hóa đơn!\n";
                    flg = false;
                }
                if (flg)
                {
                    if (ctl.updateHD(HD.SOHD, txtTongTien.Text, txtTienKH.Text, txtTienTra.Text, txtTSL.Text))
                        MessageBox.Show("Cập nhật thành công");

                }
                else
                {
                    MessageBox.Show(sTmp);
                }
            }
            if (GUI.Equals("Create"))
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.checkNumber(txtTienKH.Text))
                {
                    sTmp = sTmp + "Tiền phải là số!\n";
                    flg = false;
                }
                else if (!vl.MinValue(txtTienKH, ulong.Parse(txtTongTien.Text)))
                {
                    sTmp = sTmp + "Tiền khách đưa phải lớn hơn tổng tiền của hóa đơn!\n";
                    flg = false;
                }
                if (flg)
                {
                    if (ctl.updateHD(HD.SOHD, txtTongTien.Text, txtTienKH.Text, txtTienTra.Text, txtTSL.Text))
                        MessageBox.Show("Lập hóa đơn thành công");
                    GUI = "Cancel";
                    this.Close();
                }
                else
                {
                    MessageBox.Show(sTmp);
                    txtMaSP.Text = "";
                }
            }
        }

        private void txtTienKH_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtTienKH_Leave(null, null);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (GUI.Equals("Edit"))
            {
                btnSave_Click(null, null);
                GUI = "Cancel";
                this.Close();
            }
            else if (GUI.Equals("Create"))
            {
                btnHuy_Click(null, null);
            }

        }

        private void txtTienKH_Leave(object sender, EventArgs e)
        {
            string sTmp = "";
            bool flg = true;
            if (!vl.checkNumber(txtTienKH.Text))
            {
                sTmp = sTmp + "Tiền phải là số!\n";
                flg = false;
            }
            else if (!vl.MinValue(txtTienKH, ulong.Parse(txtTongTien.Text)))
            {
                sTmp = sTmp + "Tiền khách đưa phải lớn hơn tổng tiền của hóa đơn!\n";
                flg = false;
            }
            if (flg)
            {
                ulong tientra = ulong.Parse(txtTienKH.Text) - ulong.Parse(txtTongTien.Text);
                txtTienTra.Text = tientra.ToString();
                txtTienKH.Text = null;
                ulong tmp = ulong.Parse(txtTienTra.Text) + ulong.Parse(txtTongTien.Text);
                txtTienKH.Text = tmp.ToString();

            }
            else
            {
                MessageBox.Show(sTmp);
                txtTienKH.Text = "";
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Hủy hóa đơn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (ctl.deleteHD(HD.SOHD))
                {
                    MessageBox.Show("Hủy hóa đơn thành công!");
                    GUI = "Cancel";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Hủy hóa đơn thất bại!");
                }
            }
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
                GUI_CTHD_Load(null, null);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            btnSearch_Click(null, null);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            lstCTHD.DataSource = ctl.searchCTHD(txtSearch.Text, HD);
        }

        private void GUI_CTHD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (GUI.Equals("Create"))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Hủy hóa đơn này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deleteHD(HD.SOHD))
                    {
                        MessageBox.Show("Hủy hóa đơn thành công!");
                        GUI_QLHD qlhd = new GUI_QLHD(TK, POS);
                        this.Hide();
                        qlhd.ShowDialog();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (GUI.Equals("Cancel") || GUI.Equals("Edit"))
            {
                GUI_QLHD form = new GUI_QLHD(TK, POS);
                this.Hide();
                form.ShowDialog();
                e.Cancel = false;
            }
        }

    }
}
