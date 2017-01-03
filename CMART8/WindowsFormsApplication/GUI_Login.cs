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
    public partial class GUI_Login : Form
    {
        CMART8Entities db;
        TAIKHOAN TK;
        ValidationExtension vl;
        public GUI_Login()
        {
            db = new CMART8Entities();
            vl = new ValidationExtension();
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            string sTmp = "";
            bool flg = true;
            if (!vl.Required(txtUser.Text))
            {
                sTmp = sTmp + "Vui lòng điền tên đăng nhập!\n";
                flg = false;
            }
            if (!vl.Required(txtPass.Text))
            {
                sTmp = sTmp + "Vui lòng điền mật khẩu!\n";
                flg = false;
            }
            if (flg)
            {
                try
                {
                    TK = db.TAIKHOANs.Single(st => st.TENDANGNHAP.Equals(txtUser.Text) && st.MATKHAU.Equals(txtPass.Text));
                        if (TK.QUYEN.Equals("Giám đốc"))
                        {
                            GUI_Thongke tk = new GUI_Thongke(TK);
                            this.Hide();
                            tk.ShowDialog();
                            this.Close();
                        }
                        else if (TK.QUYEN.Equals("Nhân viên bán hàng"))
                        {
                            QLHD.GUI_POS sp = new QLHD.GUI_POS(TK,"Login");
                            this.Hide();
                            sp.ShowDialog();
                            this.Close();
                        }
                        else if (TK.QUYEN.Equals("Quản lý chi nhánh"))
                        {
                            QLNH.GUI_DX sp = new QLNH.GUI_DX(TK);
                            this.Hide();
                            sp.ShowDialog();
                            this.Close();
                        }
                        else if (TK.QUYEN.Equals("Nhân viên kiểm kho"))
                        {
                            QLNH.GUI_NHTS sp = new QLNH.GUI_NHTS(TK);
                            this.Hide();
                            sp.ShowDialog();
                            this.Close();
                        }
                        else if (TK.QUYEN.Equals("Thư ký"))
                        {
                            Dexuat.GUI_DX sp = new Dexuat.GUI_DX(TK);
                            this.Hide();
                            sp.ShowDialog();
                            this.Close();
                        }
                }
                catch
                {
                    MessageBox.Show("Tên đăng nhập hoặc mật khẩu không chính xác!");
                    txtPass.Text = "";
                }
            }
            else
            {
                MessageBox.Show(sTmp);
            }
        }

        private void txtPass_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnCancel_Click(this, new EventArgs());
            }
        }
    }
}
