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
    public partial class GUI_CTTS : Form
    {
        BUS_NHTS ctl;
        CMART8Entities db;
        TAIKHOAN TK;
        PHIEUNHAPHANGTRUSO PN;
        int flg = 0;
        string tt = "Create";
        public GUI_CTTS(TAIKHOAN tmp, PHIEUNHAPHANGTRUSO tmp2)
        {
            TK = tmp;
            PN = tmp2;
            ctl = new BUS_NHTS();
            db = new CMART8Entities();
            InitializeComponent();
            txtNg.Text = TK.HOTEN;
        }
        private void cbSP_SelectedValueChanged(object sender, EventArgs e)
        {
            if (flg > 1)
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
            cbSP.DataSource = ctl.loadListPDX();
            cbSP.DisplayMember = "SOPHIEUDX";
            cbSP.ValueMember = "SOPHIEUDX";
            cbSP.SelectedItem = null;

        }

        private void lst_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            loadTien();
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
            if (ctl.addListCTNHTS(ctpn))
            {
                if (ctl.updatePNHTS(PN, txtTongTien.Text, cbSP.Text))
                {
                    GUI_NHTS form = new GUI_NHTS(TK);
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

        private void GUI_CTTS_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tt.Equals("Create"))
            {
                DialogResult dlr = MessageBox.Show("Bạn có chắc chắn Hủy Phiếu nhập hàng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dlr == DialogResult.OK)
                {
                    if (ctl.deletePN(PN))
                    {
                        MessageBox.Show("Hủy Phiếu nhập hàng thành công!");
                        GUI_NHTS form = new GUI_NHTS(TK);
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
                GUI_NHTS form = new GUI_NHTS(TK);
                this.Hide();
                form.ShowDialog();
                e.Cancel = false;
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

    }
}
