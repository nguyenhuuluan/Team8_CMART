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
    public partial class GUI_Thongke : Form
    {
        TAIKHOAN TK;
        BUS_ThongKe ctl;
        string THk = "Ngay";
        ValidationExtension vl;
        public GUI_Thongke(TAIKHOAN tmp)
        {
            TK = tmp;
            ctl = new BUS_ThongKe();
            vl = new ValidationExtension();
            InitializeComponent();
            rdNgay.Checked = true;
            controlFunction(TK.QUYEN);
        }

        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Giám đốc"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLHD.Visible = false;
                formQLNH.Visible = false;
            }
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

        private void formLSG_Click(object sender, EventArgs e)
        {
            GUI_LichSuGia lsg = new GUI_LichSuGia(TK);
            this.Hide();
            lsg.ShowDialog();
            this.Close();
        }

        private void formQLTK_Click(object sender, EventArgs e)
        {
            GUI_QLTK qltk = new GUI_QLTK(TK);
            this.Hide();
            qltk.ShowDialog();
            this.Close();
        }

        private void formDoiMK_Click(object sender, EventArgs e)
        {
            QLTK.GUI.GUI_DoiMK ncc = new QLTK.GUI.GUI_DoiMK(TK);
            this.Hide();
            ncc.ShowDialog();
            this.Close();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            GUI_Login lg = new GUI_Login();
            this.Hide();
            lg.ShowDialog();
            this.Close();
        }

        private void GUI_Thongke_Load(object sender, EventArgs e)
        {

        }
        private const int DTM_GETMONTHCAL = 0x1000 + 8;
        private const int MCM_SETCURRENTVIEW = 0x1000 + 32;
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);

        private void rdNgay_CheckedChanged(object sender, EventArgs e)
        {
            controlFunction2("Ngay");
        }

        private void rdThang_CheckedChanged(object sender, EventArgs e)
        {
            controlFunction2("Thang");
        }

        private void controlFunction2(string sTmp)
        {
            if (sTmp.Equals("Ngay"))
            {
                txtNgayBD.Enabled = true;
                THk = sTmp;
                txtNgayBD.CustomFormat = "dd/MM/yyyy";
                txtNgayBD.ShowUpDown = false;
                txtNgayKT.Visible = false;
                lblKT.Visible = false;
            }
            else if (sTmp.Equals("Thang"))
            {
                txtNgayBD.Enabled = true;
                THk = sTmp;
                txtNgayBD.CustomFormat = "MM/yyyy";
                txtNgayBD.ShowUpDown = false;
                txtNgayKT.Visible = false;
                lblKT.Visible = false;
            }
            else if (sTmp.Equals("Nam"))
            {
                txtNgayBD.Enabled = true;
                THk = sTmp;
                txtNgayBD.CustomFormat = "yyyy";
                txtNgayBD.ShowUpDown = true;
                txtNgayKT.Visible = false;
                lblKT.Visible = false;
            }
            else if (sTmp.Equals("TG"))
            {
                txtNgayBD.Enabled = true;
                THk = sTmp;
                txtNgayBD.CustomFormat = "dd/MM/yyyy";
                txtNgayBD.ShowUpDown = false;
                txtNgayKT.Visible = true;
                lblKT.Visible = true;
            }
        }

        private void txtNgayBD_DropDown(object sender, EventArgs e)
        {
            if (THk.Equals("Thang"))
            {
                IntPtr cal = SendMessage(txtNgayBD.Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero);
                SendMessage(cal, MCM_SETCURRENTVIEW, IntPtr.Zero, (IntPtr)1);
            }
        }

        private void rdNam_CheckedChanged(object sender, EventArgs e)
        {
            controlFunction2("Nam");
        }

        private void rdTG_CheckedChanged(object sender, EventArgs e)
        {
            controlFunction2("TG");
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (THk.Equals("Ngay"))
            {
                int ngay = int.Parse(txtNgayBD.Value.Day + "");
                int thang = int.Parse(txtNgayBD.Value.Month.ToString());
                int nam = int.Parse(txtNgayBD.Value.Year.ToString());
                lst.DataSource = ctl.thongKeNgay(ngay, thang, nam);
            }
            else if (THk.Equals("Thang"))
            {
                int thang = int.Parse(txtNgayBD.Value.Month.ToString());
                int nam = int.Parse(txtNgayBD.Value.Year.ToString());
                lst.DataSource = ctl.thongKeThang(thang, nam);
            }
            else if (THk.Equals("Nam"))
            {
                int nam = int.Parse(txtNgayBD.Value.Year.ToString());
                lst.DataSource = ctl.thongKeNam(nam);
            }
            else if (THk.Equals("TG"))
            {
                string sTmp = "";
                bool flg = true;
                if (!vl.dateTime(txtNgayBD.Value, txtNgayKT.Value))
                {
                    sTmp = sTmp + "Vui lòng nhập thời gian kết thúc sau thời gian bắt đầu!\n";
                    flg = false;
                }
                if (flg)
                {
                    lst.DataSource = ctl.thongKeTg(txtNgayBD.Value, txtNgayKT.Value);
                }
                else
                {
                    MessageBox.Show(sTmp);
                }
            }
            calculator();
        }
        private void calculator()
        {
            double Tongtien = 0.0;
            int TongSL = 0;
            for (int i = 0; i < lst.Rows.Count; i++)
            {
                Tongtien += double.Parse(lst.Rows[i].Cells[5].Value.ToString());
                TongSL += int.Parse(lst.Rows[i].Cells[4].Value.ToString());
            }
            txtTSL.Text = TongSL.ToString();
            txtTDT.Text = string.Format("{0:#,##0.##}", Tongtien);
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            btnXem_Click(null, null);
            if (THk.Equals("Ngay"))
            {
                ThongKe.GUI_Report rp = new ThongKe.GUI_Report(txtNgayBD.Value, txtNgayKT.Value, THk);
                rp.ShowDialog();
            }
            else if (THk.Equals("Thang"))
            {
                ThongKe.GUI_Report rp = new ThongKe.GUI_Report(txtNgayBD.Value, txtNgayKT.Value, THk);
                rp.ShowDialog();
            }
            else if (THk.Equals("Nam"))
            {
                ThongKe.GUI_Report rp = new ThongKe.GUI_Report(txtNgayBD.Value, txtNgayKT.Value, THk);
                rp.ShowDialog();
            }
            else if (THk.Equals("TG"))
            {
                bool flg = true;
                if (!vl.dateTime(txtNgayBD.Value, txtNgayKT.Value))
                {
                    flg = false;
                }
                if (flg)
                {
                    btnXem_Click(null, null);
                    ThongKe.GUI_Report rp = new ThongKe.GUI_Report(txtNgayBD.Value, txtNgayKT.Value, THk);
                    rp.ShowDialog();
                }
            }
        }
    }
}
