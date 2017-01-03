using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.QLNH
{
    public partial class GUI_CTDX : Form
    {
        BUS_NHCN ctl;
        TAIKHOAN TK;
        PHIEUNHAPHANGCHINHANH PN;
        CMART8Entities db;
        int flg = 0;
        string tt = "Create";
        public GUI_CTDX(PHIEUNHAPHANGCHINHANH pn, TAIKHOAN tk)
        {
            TK = tk;
            PN = pn;
            ctl = new BUS_NHCN();
            db = new CMART8Entities();
            InitializeComponent();
            txtNgay.Text = PN.NGAYNHAP.ToString();
            txtNg.Text = TK.HOTEN;
            cbCN.SelectedIndex = 0;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Hủy Phiếu nhập hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dlr == DialogResult.OK)
            {
                if (ctl.deletePN(PN))
                {
                    MessageBox.Show("Hủy Phiếu nhập hàng thành công!");
                    tt = "Cancel";
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Hủy phiếu nhập hàng thất bại!");
                }
            }
        }
        private void GUI_CTCN_Load(object sender, EventArgs e)
        {
            cbTS.DataSource = ctl.loadListNHTS();
            cbTS.DisplayMember = "SOPHIEU";
            cbTS.ValueMember = "SOPHIEU";
            cbTS.SelectedItem = null;
        }

        private void cbTS_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flg > 1)
            {
                lst.Rows.Clear();
                var tmp = ctl.loadListCTTS(cbTS.Text);
                foreach (var item in tmp)
                {
                    ArrayList row = new ArrayList();
                    row.Add(PN.SOPHIEU);
                    SANPHAM sp = db.SANPHAMs.Find(item.MASP);
                    row.Add(sp.TENSP);
                    row.Add(item.MASP);
                    row.Add(item.SOLUONG);
                    row.Add("Đủ");
                    lst.Rows.Add(row.ToArray());
                }
            }
            loadTSL();
            flg++;
        }
        private void loadTSL()
        {
            int sl = 0;
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                sl += Convert.ToInt32(lst.Rows[i].Cells[2].Value);
            }
            txtTSL.Text = sl.ToString();
        }
        private void GUI_CTCN_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tt.Equals("Create"))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Hủy Phiếu nhập hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deletePN(PN))
                    {
                        MessageBox.Show("Hủy phiếu nhập hàng thành công!");
                        GUI_DX form = new GUI_DX(TK);
                        this.Hide();
                        form.ShowDialog();
                        e.Cancel = false;
                    }
                    else
                    {
                        e.Cancel = true;
                        MessageBox.Show("Hủy phiếu nhập hàng thất bại!");
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            List<CTPHIEUNHAPHANGCHINHANH> ctpn = new List<CTPHIEUNHAPHANGCHINHANH>();
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                CTPHIEUNHAPHANGCHINHANH tmp = new CTPHIEUNHAPHANGCHINHANH();
                tmp.SOPHIEUNHCN = lst.Rows[i].Cells[0].Value.ToString();
                tmp.MASP = lst.Rows[i].Cells[2].Value.ToString();
                tmp.SOLUONG = int.Parse(lst.Rows[i].Cells[3].Value.ToString());
                tmp.TINHTRANG = lst.Rows[i].Cells[4].Value.ToString();
                ctpn.Add(tmp);
            }
            if (ctl.addListCTNHCN(ctpn))
            {
                if (ctl.updatePNHTS(PN, cbTS.Text, cbCN.Text))
                {
                    GUI_DX form = new GUI_DX(TK);
                    tt = "Cancel";
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Thất bại!");
                }
            }
            else
            {
                MessageBox.Show("Thất bại!");
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
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                lst.Rows[i].Visible = false;
                if (lst.Rows[i].Cells[1].Value.ToString().Contains(txtSearch.Text) || lst.Rows[i].Cells[2].Value.ToString().Contains(txtSearch.Text))
                {
                    lst.Rows[i].Visible = true;
                }
                else
                {
                    lst.Rows[i].Visible = false;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            if (txtSearch.Text != "" && txtSearch.Text != txtSearch.Tag.ToString())
            {
                btnSearch_Click(null, null);
            }
            else
            {
                controlFunction("visible");
            }
        }
        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("visible"))
            {
                for (int i = 0; i < lst.RowCount; i++)
                {
                    lst.Rows[i].Visible = true;
                }
            }
        }
    }
}
