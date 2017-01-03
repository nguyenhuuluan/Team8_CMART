using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.Dexuat
{
    public partial class GUI_CTDX : Form
    {
        CMART8Entities db;
        PHIEUDEXUAT PDX;
        TAIKHOAN TK;
        BUS_DX ctl;
        string tt;
        public GUI_CTDX(TAIKHOAN tk, PHIEUDEXUAT pdx, string tmp)
        {
            TK = tk;
            PDX = pdx;
            tt = tmp;
            ctl = new BUS_DX();
            db = new CMART8Entities();
            InitializeComponent();
            controlFunction(tt);
            TAIKHOAN tk2 = db.TAIKHOANs.Find(PDX.MATK);
            txtNg.Text = tk2.HOTEN;
            txtNgay.Text = PDX.NGAYDEXUAT.ToString();
            loadlistCTDX();
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Edit"))
            {
                btnSave.Text = "Cập nhật";
                btnHuy.Text = "Quay lại";
                NHACUNGCAP ncc = db.NHACUNGCAPs.Find(PDX.MANCC);
                cbNCC.Text = ncc.TENNCC;
            }
        }
        private void GUI_CTDX_Load(object sender, EventArgs e)
        {
            cbNCC.DataSource = db.NHACUNGCAPs.ToList();
            cbNCC.DisplayMember = "TENNCC";
            cbNCC.ValueMember = "MANCC";
            if (tt.Equals("Edit"))
            {
                NHACUNGCAP ncc = db.NHACUNGCAPs.Find(PDX.MANCC);
                cbNCC.Text = ncc.TENNCC;
            }
        }
        private void loadlistCTDX()
        {
            lst.Rows.Clear();
            var tmp = ctl.loadlistCTPDX(PDX);
            foreach (var item in tmp)
            {
                ArrayList row = new ArrayList();
                row.Add(item.MASP);
                SANPHAM sp = db.SANPHAMs.Find(item.MASP);
                row.Add(sp.TENSP);
                row.Add(item.SOLUONG);
                lst.Rows.Add(row.ToArray());
            }
            TSL();
            if (lst.RowCount > 0)
            {
                cbNCC.Enabled = false;
            }
            else
            {
                cbNCC.Enabled = true;
            }
        }
        private void TSL()
        {
            int sl = 0;
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                sl += Convert.ToInt32(lst.Rows[i].Cells[2].Value);
            }
            txtTSL.Text = sl.ToString();

        }

        private void cbNCC_SelectedValueChanged(object sender, EventArgs e)
        {
            NHACUNGCAP ncc = (NHACUNGCAP)cbNCC.SelectedItem;
            List<SANPHAM> sp = db.SANPHAMs.ToList().Where(x => x.MANCC.Equals(ncc.MANCC)).ToList();
            cbSP.DataSource = sp;
            cbSP.DisplayMember = "TENSP";
            cbSP.ValueMember = "MASP";
            //    cbSP.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //    cbSP.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void cbSP_SelectedValueChanged(object sender, EventArgs e)
        {
            txtMASP.Text = db.SANPHAMs.Single(x => x.MASP.Equals(((SANPHAM)cbSP.SelectedItem).MASP)).MASP;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (ctl.addCTPDX(txtMASP.Text, txtSL.Value.ToString(), PDX))
            {
                MessageBox.Show("Thêm mới thành công!");
                loadlistCTDX();
            }
            else
            {
                MessageBox.Show("Thếm mới thất bại!");
            }
        }

        private void txtSL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }

        private void cbSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnAdd_Click(null, null);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Xóa?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (ctl.deleteCTPDX(lst.SelectedRows[0].Cells[0].Value.ToString(), PDX))
                {
                    MessageBox.Show("Xóa thành công!");
                    loadlistCTDX();
                }
                else
                {
                    MessageBox.Show("Xóa không thành công!");
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tt.Equals("Add"))
            {
                NHACUNGCAP ncc = (NHACUNGCAP)cbNCC.SelectedItem;
                if (ctl.updatePDX(PDX, ncc.MANCC))
                {
                    MessageBox.Show("Lập phiếu đề xuất thành công!");
                    tt = "Cancel";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Lập phiếu đề xuất thất bại!");
                }
            }
            else if (tt.Equals("Edit"))
            {
                NHACUNGCAP ncc = (NHACUNGCAP)cbNCC.SelectedItem;
                if (ctl.updatePDX(PDX, ncc.MANCC))
                {
                    MessageBox.Show("Cập nhật phiếu đề xuất thành công!");
                    tt = "Cancel";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật phiếu đề xuất thất bại!");
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (tt.Equals("Add"))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn hủy phiếu đề xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deletePDX(PDX))
                    {
                        MessageBox.Show("Hủy phiếu đề xuất thành công!");
                        tt = "Cancel";
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Hủy phiếu đề xuất thất bại!");
                    }
                }
            }
            else if (tt.Equals("Edit"))
            {
                btnSave_Click(null, null);
            }
        }

        private void GUI_CTDX_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tt.Equals("Add"))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn hủy phiếu đề xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deletePDX(PDX))
                    {
                        MessageBox.Show("Hủy phiếu đề xuất thành công!");
                        GUI_DX form = new GUI_DX(TK);
                        this.Hide();
                        form.ShowDialog();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("Hủy phiếu đề xuất thất bại!");
                    }
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else if (tt.Equals("Cancel"))
            {
                GUI_DX form = new GUI_DX(TK);
                this.Hide();
                form.ShowDialog();
                e.Cancel = false;
            }
        }
    }
}
