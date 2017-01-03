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
    public partial class GUI_CTDX_Update : Form
    {
        BUS_NHCN_Update udt;
        BUS_NHCN ctl;
        TAIKHOAN TK;
        PHIEUNHAPHANGCHINHANH PN;
        CMART8Entities db;
        int flg = 0;
        public GUI_CTDX_Update(TAIKHOAN tk, PHIEUNHAPHANGCHINHANH pn)
        {
            PN = pn;
            TK = tk;
            db = new CMART8Entities();
            udt = new BUS_NHCN_Update();
            ctl = new BUS_NHCN();
            InitializeComponent();
            txtNgay.Text = PN.NGAYNHAP.ToString();
            cbTS.Text = PN.SOPHIEUNHTS;
            cbCN.Text = PN.CHINHANH;
            txtNg.Text = TK.HOTEN;
        }

        private void GUI_CTCN_Update_Load(object sender, EventArgs e)
        {
            cbTS.DataSource = udt.loadListPTS(PN);
            cbTS.DisplayMember = "SOPHIEU";
            cbTS.ValueMember = "SOPHIEU";
            cbTS.Text = PN.SOPHIEUNHTS;
        }

        private void cbTS_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbTS.Text.Equals(PN.SOPHIEUNHTS))
            {
                lst.Rows.Clear();
                var tmp = udt.loadListCTNHCN(PN);
                foreach (var item in tmp)
                {
                    ArrayList row = new ArrayList();
                    row.Add(PN.SOPHIEU);
                    SANPHAM sp = db.SANPHAMs.Find(item.MASP);
                    row.Add(sp.TENSP);
                    row.Add(item.MASP);
                    row.Add(item.SOLUONG);
                    row.Add(item.TINHTRANG);
                    lst.Rows.Add(row.ToArray());
                }
            }
            else if (flg > 1)
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
                    row.Add(item.TINHTRANG);
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
                sl += Convert.ToInt32(lst.Rows[i].Cells[3].Value);
            }
            txtTSL.Text = sl.ToString();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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
            if (udt.updateListCTCN(ctpn, PN))
            {
                if (udt.updatePNHCN(PN, cbTS.Text, cbCN.Text, txtNgay.Value))
                {
                    MessageBox.Show("Cập nhật thành công!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
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

        private void GUI_CTCN_Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI_DX form = new GUI_DX(TK);
            this.Hide();
            form.ShowDialog();
            e.Cancel = false;
        }
    }
}
