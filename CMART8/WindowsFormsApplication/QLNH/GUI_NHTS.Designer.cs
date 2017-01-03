namespace CMART8.QLNH
{
    partial class GUI_NHTS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_NHTS));
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
            this.lstNHTS = new System.Windows.Forms.DataGridView();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNHTS)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::CMART8.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(904, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 26);
            this.btnLogout.TabIndex = 90;
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
            this.lblQuyen.Size = new System.Drawing.Size(269, 23);
            this.lblQuyen.TabIndex = 89;
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
            this.menuStrip1.Size = new System.Drawing.Size(960, 26);
            this.menuStrip1.TabIndex = 88;
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
            // lstNHTS
            // 
            this.lstNHTS.AllowUserToAddRows = false;
            this.lstNHTS.AllowUserToDeleteRows = false;
            this.lstNHTS.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstNHTS.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstNHTS.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lstNHTS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstNHTS.DefaultCellStyle = dataGridViewCellStyle2;
            this.lstNHTS.Location = new System.Drawing.Point(15, 158);
            this.lstNHTS.Name = "lstNHTS";
            this.lstNHTS.ReadOnly = true;
            this.lstNHTS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstNHTS.Size = new System.Drawing.Size(938, 297);
            this.lstNHTS.TabIndex = 87;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(7, 151);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(946, 4);
            this.button6.TabIndex = 86;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(168, 30);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(4, 118);
            this.button7.TabIndex = 85;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(362, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(4, 118);
            this.button5.TabIndex = 84;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(549, 30);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(4, 118);
            this.button8.TabIndex = 83;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(583, 108);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 40);
            this.txtSearch.TabIndex = 81;
            this.txtSearch.Tag = "Searching";
            this.txtSearch.Text = "Searching";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.Enter += new System.EventHandler(this.txtSearch_Enter);
            this.txtSearch.Leave += new System.EventHandler(this.txtSearch_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(708, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(245, 33);
            this.label4.TabIndex = 80;
            this.label4.Text = "Quản lý phiếu nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(424, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 23);
            this.label3.TabIndex = 79;
            this.label3.Text = "In phiếu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(43, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 23);
            this.label1.TabIndex = 76;
            this.label1.Text = "Lập phiếu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Maroon;
            this.label9.Location = new System.Drawing.Point(206, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(121, 23);
            this.label9.TabIndex = 77;
            this.label9.Text = "Chi tiết phiếu";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::CMART8.Properties.Resources.Chitiet;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(231, 43);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(72, 65);
            this.button1.TabIndex = 74;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::CMART8.Properties.Resources.printer;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(428, 43);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 65);
            this.btnDelete.TabIndex = 73;
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::CMART8.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(52, 43);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 65);
            this.btnAdd.TabIndex = 75;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CMART8.Properties.Resources.find2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(913, 108);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 71;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DarkRed;
            this.label5.Location = new System.Drawing.Point(802, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 33);
            this.label5.TabIndex = 80;
            this.label5.Text = "hàng trụ sở";
            // 
            // GUI_NHTS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 470);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lstNHTS);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.txtSearch);
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
            this.Name = "GUI_NHTS";
            this.Text = "Quan ly phieu nhap hang tru so";
            this.Load += new System.EventHandler(this.GUI_NHTS_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lstNHTS)).EndInit();
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
        private System.Windows.Forms.DataGridView lstNHTS;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label5;
    }
}