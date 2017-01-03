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
    public partial class GUI_CTTS_Update : Form
    {
        BUS_NHTS ctl;
        BUS_NHTS_Update udt;
        CMART8Entities db;
        TAIKHOAN TK;
        PHIEUNHAPHANGTRUSO PN;
        int flg = 0;
        public GUI_CTTS_Update(TAIKHOAN tmp, PHIEUNHAPHANGTRUSO tmp2)
        {
            TK = tmp;
            PN = tmp2;
            ctl = new BUS_NHTS();
            udt = new BUS_NHTS_Update();
            db = new CMART8Entities();
            InitializeComponent();
            txtNg.Text = TK.HOTEN;
            cbSP.Text = PN.SOPHIEUDX;
            txtNgay.Text = PN.NGAYNHAP.ToString();
        }
        private void cbSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbSP.Text.Equals(PN.SOPHIEUDX))
            {
                lst.Rows.Clear();
                var tmp = udt.loadListCTNHTS(PN);
                foreach (var item in tmp)
                {
                    ArrayList row = new ArrayList();
                    row.Add(PN.SOPHIEU);
                    SANPHAM sp = db.SANPHAMs.Find(item.MASP);
                    row.Add(sp.TENSP);
                    row.Add(item.MASP);
                    row.Add(item.SOLUONG);
                    row.Add(item.TINHTRANG);
                    row.Add(item.GIANHAP);
                    row.Add(item.HANSD.Value.ToShortDateString());
                    lst.Rows.Add(row.ToArray());
                }
                loadTien();
            }
            else if (flg > 1)
            {
                lst.Rows.Clear();
                var tmp = ctl.loadListCTDX(cbSP.Text);
                foreach (var item in tmp)
                {
                    ArrayList row = new ArrayList();
                    row.Add(PN.SOPHIEU);
                    SANPHAM sp = db.SANPHAMs.Find(item.MASP);
                    row.Add(sp.TENSP);
                    row.Add(item.MASP);
                    row.Add(item.SOLUONG);
                    row.Add("Đủ");
                    row.Add("0");
                    row.Add(DateTime.Now.AddMonths(6).ToShortDateString());
                    lst.Rows.Add(row.ToArray());
                }
                loadTien();
            }
            flg++;
        }
        private void loadTien()
        {
            ulong sum = 0;
            int sl = 0;
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                sum += Convert.ToUInt64(lst.Rows[i].Cells[5].Value) * Convert.ToUInt64(lst.Rows[i].Cells[3].Value);
                sl += Convert.ToInt32(lst.Rows[i].Cells[3].Value);
            }
            txtTongTien.Text = sum.ToString();
            txtTSL.Text = sl.ToString();
        }
        private void GUI_CTTS_Load(object sender, EventArgs e)
        {
            cbSP.DataSource = udt.loadListPDX(PN);
            cbSP.DisplayMember = "SOPHIEUDX";
            cbSP.ValueMember = "SOPHIEUDX";
            cbSP.Text = PN.SOPHIEUDX;
        }

        private void lst_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            loadTien();
        }

        private void lst_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //MessageBox.Show(lst.CurrentRow.Cells[2].Value.ToString());
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            //MessageBox.Show(lst.Rows[lst.Rows.Count-1].Cells[1].Value.ToString());
            //THêm mới
            List<CTPHIEUNHAPHANGTRUSO> ctpn = new List<CTPHIEUNHAPHANGTRUSO>();
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                CTPHIEUNHAPHANGTRUSO tmp = new CTPHIEUNHAPHANGTRUSO();
                tmp.SOPHIEUNHTS = lst.Rows[i].Cells[0].Value.ToString();
                tmp.MASP = lst.Rows[i].Cells[2].Value.ToString();
                tmp.SOLUONG = int.Parse(lst.Rows[i].Cells[3].Value.ToString());
                tmp.GIANHAP = ulong.Parse(lst.Rows[i].Cells[5].Value.ToString());
                tmp.HANSD = DateTime.Parse(lst.Rows[i].Cells[6].Value.ToString());
                tmp.TINHTRANG = lst.Rows[i].Cells[4].Value.ToString();
                ctpn.Add(tmp);
            }
            if (udt.updateListCTTS(ctpn, PN))
            {
                if (udt.updatePNHTS(PN, cbSP.Text, txtTongTien.Text, TK.MATK, txtNgay.Value))
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

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void GUI_CTTS_Update_FormClosing(object sender, FormClosingEventArgs e)
        {
            GUI_NHTS form = new GUI_NHTS(TK);
            this.Hide();
            form.ShowDialog();
            e.Cancel = false;
        }

    }
}
