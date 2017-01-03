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
    public partial class GUI_POS : Form
    {
        TAIKHOAN TK;
        string sTmp;
        public GUI_POS(TAIKHOAN tmp, string tmp2)
        {
            TK = tmp;
            sTmp = tmp2;
            InitializeComponent();
            cbPOS.SelectedIndex = 0;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            GUI_QLHD hd = new GUI_QLHD(TK, cbPOS.Text);
            this.Hide();
            hd.ShowDialog();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if(sTmp.Equals("Login"))
            {
                GUI_Login lg = new GUI_Login();
                this.Hide();
                lg.ShowDialog();
                this.Close();
            }
            if(sTmp.Equals("editMK"))
            {
                QLTK.GUI.GUI_DoiMK hd = new QLTK.GUI.GUI_DoiMK(TK);
                this.Hide();
                hd.ShowDialog();
                this.Close();
            }
        }
    }
}
