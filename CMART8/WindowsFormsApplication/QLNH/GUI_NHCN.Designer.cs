namespace CMART8.QLNH
{
    partial class GUI_DX
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_DX));
            this.btnLogout = new System.Windows.Forms.Button();
            this.lblQuyen = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.formQLHD = new System.Windows.Forms.ToolStripMenuItem();
            this.formQLDM = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýNhàToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinKhuyếnMãiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formLSG = new System.Windows.Forms.ToolStripMenuItem();
            this.formQLNH = new System.Windows.Forms.ToolStripMenuItem();
            this.formNHTS = new System.Windows.Forms.ToolStripMenuItem();
            this.formNHCN = new System.Windows.Forms.ToolStripMenuItem();
            this.formThongke = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLyTaiKhoanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.formDoiMK = new System.Windows.Forms.ToolStripMenuItem();
            this.formQLTK = new System.Windows.Forms.ToolStripMenuItem();
            this.lstNHCN = new System.Windows.Forms.DataGridView();
            this.button8 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNHCN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::CMART8.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(886, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 26);
            this.btnLogout.TabIndex = 111;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQuyen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuyen.Location = new System.Drawing.Point(633, 3);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(251, 23);
            this.lblQuyen.TabIndex = 110;
            this.lblQuyen.Text = "Giám đốc";
            this.lblQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formQLHD,
            this.formQLDM,
            this.formQLNH,
            this.formThongke,
            this.quanLyTaiKhoanToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(946, 26);
            this.menuStrip1.TabIndex = 109;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formQLHD
            // 
            this.formQLHD.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formQLHD.Name = "formQLHD";
            this.formQLHD.Size = new System.Drawing.Size(129, 22);
            this.formQLHD.Text = "Quản lý hóa đơn";
            // 
            // formQLDM
            // 
            this.formQLDM.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formQLDM.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quảnLýSảnPhẩmToolStripMenuItem,
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem,
            this.quảnLýNhàToolStripMenuItem,
            this.thôngTinKhuyếnMãiToolStripMenuItem,
            this.formLSG});
            this.formQLDM.Name = "formQLDM";
            this.formQLDM.Size = new System.Drawing.Size(140, 22);
            this.formQLDM.Text = "Quản lý danh mục";
            // 
            // quảnLýSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            // 
            // quảnLýNhàToolStripMenuItem
            // 
            this.quảnLýNhàToolStripMenuItem.Name = "quảnLýNhàToolStripMenuItem";
            this.quảnLýNhàToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýNhàToolStripMenuItem.Text = "Nhà cung cấp";
            // 
            // thôngTinKhuyếnMãiToolStripMenuItem
            // 
            this.thôngTinKhuyếnMãiToolStripMenuItem.Name = "thôngTinKhuyếnMãiToolStripMenuItem";
            this.thôngTinKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thôngTinKhuyếnMãiToolStripMenuItem.Text = "Thông tin khuyến mãi";
            // 
            // formLSG
            // 
            this.formLSG.Name = "formLSG";
            this.formLSG.Size = new System.Drawing.Size(218, 22);
            this.formLSG.Text = "Lịch sử giá";
            // 
            // formQLNH
            // 
            this.formQLNH.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.formQLNH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formNHTS,
            this.formNHCN});
            this.formQLNH.Name = "formQLNH";
            this.formQLNH.Size = new System.Drawing.Size(144, 22);
            this.formQLNH.Text = "Quản lý nhập hàng";
            // 
            // formNHTS
            // 
            this.formNHTS.Name = "formNHTS";
            this.formNHTS.Size = new System.Drawing.Size(214, 22);
            this.formNHTS.Text = "Nhập hàng trụ sở";
            // 
            // formNHCN
            // 
            this.formNHCN.Name = "formNHCN";
            this.formNHCN.Size = new System.Drawing.Size(214, 22);
            this.formNHCN.Text = "Nhập hàng chi nhánh";
            // 
            // formThongke
            // 
            this.formThongke.Name = "formThongke";
            this.formThongke.Size = new System.Drawing.Size(82, 22);
            this.formThongke.Text = "Thống kê";
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formDoiMK,
            this.formQLTK});
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // formDoiMK
            // 
            this.formDoiMK.Name = "formDoiMK";
            this.formDoiMK.Size = new System.Drawing.Size(190, 22);
            this.formDoiMK.Text = "Đổi mật khẩu";
            this.formDoiMK.Click += new System.EventHandler(this.formDoiMK_Click);
            // 
            // formQLTK
            // 
            this.formQLTK.Name = "formQLTK";
            this.formQLTK.Size = new System.Drawing.Size(190, 22);
            this.formQLTK.Text = "Quản lý tài khoản";
            // 
            // lstNHCN
            // 
            this.lstNHCN.AllowUserToAddRows = false;
            this.lstNHCN.AllowUserToDeleteRows = false;
            this.lstNHCN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstNHCN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstNHCN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lstNHCN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstNHCN.DefaultCellStyle = dataGridViewCellStyle2;
            this.lstNHCN.Location = new System.Drawing.Point(11, 158);
            this.lstNHCN.Name = "lstNHCN";
            this.lstNHCN.ReadOnly = true;
            this.lstNHCN.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstNHCN.Size = new System.Drawing.Size(924, 279);
            this.lstNHCN.TabIndex = 108;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(531, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(4, 118);
            this.button8.TabIndex = 104;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(565, 108);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 40);
            this.txtSearch.TabIndex = 102;
            this.txtSearch.Tag = "Searching";
            this.txtSearch.Text = "Searching";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(361, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(4, 118);
            this.button2.TabIndex = 103;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(3, 149);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(931, 4);
            this.button6.TabIndex = 107;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(164, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(4, 118);
            this.button7.TabIndex = 106;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(735, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 33);
            this.label5.TabIndex = 101;
            this.label5.Text = "hàng chi nhánh";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(690, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 33);
            this.label4.TabIndex = 100;
            this.label4.Text = "Quản lý phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(406, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 99;
            this.label3.Text = "In phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(39, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 96;
            this.label1.Text = "Lập phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(202, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 97;
            this.label9.Text = "Chi tiết phiếu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CMART8.Properties.Resources.Chitiet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(227, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 65);
            this.button1.TabIndex = 94;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::CMART8.Properties.Resources.printer;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(410, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 65);
            this.btnDelete.TabIndex = 93;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::CMART8.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(48, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 65);
            this.btnAdd.TabIndex = 95;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CMART8.Properties.Resources.find2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(895, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 91;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // GUI_DX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 449);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstNHCN);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_DX";
            this.Text = "Quan ly phieu nhap hang chi nhanh";
            this.Load += new System.EventHandler(this.GUI_NHCN_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNHCN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblQuyen;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem formQLHD;
        private System.Windows.Forms.ToolStripMenuItem formQLDM;
        private System.Windows.Forms.ToolStripMenuItem quảnLýSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýLoạiSảnPhẩmToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýNhàToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinKhuyếnMãiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formLSG;
        private System.Windows.Forms.ToolStripMenuItem formQLNH;
        private System.Windows.Forms.ToolStripMenuItem formNHTS;
        private System.Windows.Forms.ToolStripMenuItem formNHCN;
        private System.Windows.Forms.ToolStripMenuItem formThongke;
        private System.Windows.Forms.ToolStripMenuItem quanLyTaiKhoanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem formDoiMK;
        private System.Windows.Forms.ToolStripMenuItem formQLTK;
        private System.Windows.Forms.DataGridView lstNHCN;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
    }
}