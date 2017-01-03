using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMART8.QLTK.GUI
{
    public partial class GUI_DoiMK : Form
    {
        ValidationExtension vl;
        TAIKHOAN TK;
        CMART8Entities db;
        bool flag = false;
        public GUI_DoiMK(TAIKHOAN tmp)
        {
            db = new CMART8Entities();
            vl = new ValidationExtension();
            TK = tmp;
            InitializeComponent();
            controlFunction(TK.QUYEN);
            txtTen.Text = TK.HOTEN;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (lblMKM.Visible==false && lblXNMK.Visible == false && lbTDN.Visible == false && lbMKHT.Visible == false && flag == true)
            {
                TAIKHOAN tk = db.TAIKHOANs.Single(st=>st.MATK == TK.MATK);
                tk.MATKHAU = txtPass.Text;
                TK = tk;
                db.SaveChanges();
                MessageBox.Show("Cập nhật mật khẩu mới thành công!");
                btnCancel_Click(null, null);
            }
            else
            {
                MessageBox.Show("Cập nhật mật khẩu mới không thành công!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtPass.Text = "";
            txtRePass.Text = "";
            txtTDN.Text = "";
            txtCurrPass.Text = "";
            flag = false;
        }
        private void controlFunction(string sTmp)
        {
            if (sTmp.Equals("Giám đốc"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLHD.Visible = false;
                formQLNH.Visible = false;
            }
            if (sTmp.Equals("Quản lý chi nhánh"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLTK.Visible = false;
                formNHTS.Visible = false;
                formDexuat.Visible = false;
            }
            if (sTmp.Equals("Nhân viên bán hàng"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLTK.Visible = false;
                formQLNH.Visible = false;
            }
            if (sTmp.Equals("Nhân viên kiểm kho"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLHD.Visible = false;
                formQLTK.Visible = false;
                formNHCN.Visible = false;
                formDexuat.Visible = false;
            }
            if (sTmp.Equals("Thư ký"))
            {
                lblQuyen.Text = TK.QUYEN;
                formQLDM.Visible = false;
                formThongke.Visible = false;
                formQLHD.Visible = false;
                formQLTK.Visible = false;
                formNHCN.Visible = false;
                formNHTS.Visible = false;
            }
        }

        private void txtTDN_Validating(object sender, CancelEventArgs e)
        {
            flag = false;
            bool flg = true;
            if (!vl.Required(txtTDN.Text))
            {
                lbTDN.Text = "Tên đăng nhập không được bỏ trống!";
                flg = false;
            }
            else if (!TK.TENDANGNHAP.Equals(txtTDN.Text))
            {
                lbTDN.Text = "Tên đăng nhập không chính xác!";
                flg = false;
            }
            if (!flg)
            {
                lbTDN.Visible = true;
            }
            else
            {
                flag = true;
                lbTDN.Visible = false;
            }
        }

        private void txtCurrPass_Validating(object sender, CancelEventArgs e)
        {
            flag = false;
            bool flg = true;
            if (!vl.Required(txtCurrPass.Text))
            {
                lbMKHT.Text = "Mật khẩu hiện tại không được bỏ trống!";
                flg = false;
            }
            else if (!TK.MATKHAU.Equals(txtCurrPass.Text))
            {
                lbMKHT.Text = "Mật khẩu hiện tại không chính xác!";
                flg = false;
            }
            else if (TK.MATKHAU.Equals(txtCurrPass.Text))
            {
                flg = true;
            }
            if (!flg)
            {
                lbMKHT.Visible = true;
            }
            else
            {
                flag = true;
                lbMKHT.Visible = false;
            }
        }

        private void txtPass_Validating(object sender, CancelEventArgs e)
        {
            flag = false;
            bool flg = true;
            if (!vl.Required(txtPass.Text))
            {
                lblMKM.Text = "Mật khẩu mới không được bỏ trống!";
                flg = false;
            }
            else if (!vl.PassWordType(txtPass))
            {
                lblMKM.Text = "Mật khẩu phải từ 6-15 ký tự\n và không có ký tự đặc biệt!";
                flg = false;
            }
            else if (vl.PassWordType(txtPass))
            {
                flg = true;
            }
            if (!flg)
            {
                lblMKM.Visible = true;
            }
            else
            {
                flag = true;
                lblMKM.Visible = false;
            }
        }

        private void txtRePass_Validating(object sender, CancelEventArgs e)
        {
            flag = false;
            bool flg = true;
            if (!vl.Required(txtRePass.Text))
            {
                lblXNMK.Text = "Mật khẩu xác nhận không được bỏ trống!";
                flg = false;
            }else if(!vl.Compared(txtPass, txtRePass))
            {
                lblXNMK.Text = "Mật khẩu xác nhận không chính xác!";
                flg = false;
            }
            if (!flg)
            {
                lblXNMK.Visible = true;
            }
            else
            {
                flag = true;
                lblXNMK.Visible = false;
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

        private void formThongke_Click(object sender, EventArgs e)
        {
            GUI_Thongke tk = new GUI_Thongke(TK);
            this.Hide();
            tk.ShowDialog();
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

        private void formNHTS_Click(object sender, EventArgs e)
        {
             QLNH.GUI_NHTS nhts = new QLNH.GUI_NHTS(TK);
            this.Hide();
            nhts.ShowDialog();
            this.Close();
        }

        private void formNHCN_Click(object sender, EventArgs e)
        {
            QLNH.GUI_DX nhcn = new QLNH.GUI_DX(TK);
            this.Hide();
            nhcn.ShowDialog();
            this.Close();
        }

        private void formQLHD_Click(object sender, EventArgs e)
        {
            QLHD.GUI_POS hd = new QLHD.GUI_POS(TK, "editMK");
            this.Hide();
            hd.ShowDialog();
            this.Close();
        }

        private void formDexuat_Click(object sender, EventArgs e)
        {
            Dexuat.GUI_DX hd = new Dexuat.GUI_DX(TK);
            this.Hide();
            hd.ShowDialog();
            this.Close();
        }

    }
}
