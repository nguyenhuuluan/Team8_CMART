﻿namespace CMART8
{
    partial class GUI_LichSuGia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_LichSuGia));
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cboTenSP = new System.Windows.Forms.ComboBox();
            this.lstLSG = new System.Windows.Forms.DataGridView();
            this.txtNgayHieuLuc = new System.Windows.Forms.DateTimePicker();
            this.btnLogout = new System.Windows.Forms.Button();
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
            this.lblQuyen = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.lstLSG)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 25);
            this.label7.TabIndex = 48;
            this.label7.Text = "Giá bán:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(810, 119);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 40);
            this.txtSearch.TabIndex = 50;
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
            this.label4.Location = new System.Drawing.Point(953, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 33);
            this.label4.TabIndex = 47;
            this.label4.Text = "Quản lý lịch sử giá";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(591, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 23);
            this.label3.TabIndex = 46;
            this.label3.Text = "Xóa lịch sử giá";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(277, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 23);
            this.label2.TabIndex = 45;
            this.label2.Text = "Sửa thông tin lịch sử giá";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(13, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 25);
            this.label5.TabIndex = 44;
            this.label5.Text = "Tên sản phẩm:";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(203, 410);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(371, 410);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(10, 172);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1170, 4);
            this.button6.TabIndex = 58;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(242, 41);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(4, 118);
            this.button7.TabIndex = 57;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(757, 41);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(4, 118);
            this.button8.TabIndex = 56;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(510, 182);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(4, 360);
            this.button11.TabIndex = 55;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(532, 41);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(4, 118);
            this.button5.TabIndex = 54;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtGia
            // 
            this.txtGia.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGia.Location = new System.Drawing.Point(183, 273);
            this.txtGia.Multiline = true;
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(310, 32);
            this.txtGia.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(28, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 23);
            this.label1.TabIndex = 49;
            this.label1.Text = "Thêm mới lịch sử giá";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(13, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Ngày hiệu lực:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CMART8.Properties.Resources.find2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(1140, 119);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 43;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::CMART8.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(620, 41);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 65);
            this.btnDelete.TabIndex = 40;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::CMART8.Properties.Resources.Edit2;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(349, 41);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 65);
            this.btnEdit.TabIndex = 42;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::CMART8.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(76, 41);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 65);
            this.btnAdd.TabIndex = 41;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // cboTenSP
            // 
            this.cboTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTenSP.FormattingEnabled = true;
            this.cboTenSP.Location = new System.Drawing.Point(183, 213);
            this.cboTenSP.Name = "cboTenSP";
            this.cboTenSP.Size = new System.Drawing.Size(310, 32);
            this.cboTenSP.TabIndex = 1;
            // 
            // lstLSG
            // 
            this.lstLSG.AllowUserToAddRows = false;
            this.lstLSG.AllowUserToDeleteRows = false;
            this.lstLSG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lstLSG.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstLSG.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lstLSG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstLSG.DefaultCellStyle = dataGridViewCellStyle2;
            this.lstLSG.Location = new System.Drawing.Point(520, 182);
            this.lstLSG.Name = "lstLSG";
            this.lstLSG.ReadOnly = true;
            this.lstLSG.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstLSG.Size = new System.Drawing.Size(660, 360);
            this.lstLSG.TabIndex = 65;
            // 
            // txtNgayHieuLuc
            // 
            this.txtNgayHieuLuc.CustomFormat = "MM/dd/yyyy HH:mm:ss";
            this.txtNgayHieuLuc.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNgayHieuLuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgayHieuLuc.Location = new System.Drawing.Point(183, 335);
            this.txtNgayHieuLuc.Name = "txtNgayHieuLuc";
            this.txtNgayHieuLuc.Size = new System.Drawing.Size(310, 32);
            this.txtNgayHieuLuc.TabIndex = 3;
            // 
            // btnLogout
            // 
            this.btnLogout.AccessibleDescription = "z";
            this.btnLogout.BackgroundImage = global::CMART8.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(1131, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 26);
            this.btnLogout.TabIndex = 68;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click_1);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AccessibleDescription = "z";
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
            this.menuStrip1.Size = new System.Drawing.Size(1184, 26);
            this.menuStrip1.TabIndex = 66;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formQLHD
            // 
            this.formQLHD.AccessibleDescription = "z";
            this.formQLHD.Name = "formQLHD";
            this.formQLHD.Size = new System.Drawing.Size(129, 22);
            this.formQLHD.Text = "Quản lý hóa đơn";
            // 
            // formQLDM
            // 
            this.formQLDM.AccessibleDescription = "z";
            this.formQLDM.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            this.quảnLýSảnPhẩmToolStripMenuItem.AccessibleDescription = "z";
            this.quảnLýSảnPhẩmToolStripMenuItem.Name = "quảnLýSảnPhẩmToolStripMenuItem";
            this.quảnLýSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýSảnPhẩmToolStripMenuItem.Text = "Sản phẩm";
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click_1);
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.AccessibleDescription = "z";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýNhàToolStripMenuItem
            // 
            this.quảnLýNhàToolStripMenuItem.AccessibleDescription = "z";
            this.quảnLýNhàToolStripMenuItem.Name = "quảnLýNhàToolStripMenuItem";
            this.quảnLýNhàToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýNhàToolStripMenuItem.Text = "Nhà cung cấp";
            this.quảnLýNhàToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàToolStripMenuItem_Click);
            // 
            // thôngTinKhuyếnMãiToolStripMenuItem
            // 
            this.thôngTinKhuyếnMãiToolStripMenuItem.AccessibleDescription = "z";
            this.thôngTinKhuyếnMãiToolStripMenuItem.Name = "thôngTinKhuyếnMãiToolStripMenuItem";
            this.thôngTinKhuyếnMãiToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.thôngTinKhuyếnMãiToolStripMenuItem.Text = "Thông tin khuyến mãi";
            this.thôngTinKhuyếnMãiToolStripMenuItem.Click += new System.EventHandler(this.thôngTinKhuyếnMãiToolStripMenuItem_Click);
            // 
            // formLSG
            // 
            this.formLSG.Name = "formLSG";
            this.formLSG.Size = new System.Drawing.Size(218, 22);
            this.formLSG.Text = "Lịch sử giá";
            // 
            // formQLNH
            // 
            this.formQLNH.AccessibleDescription = "z";
            this.formQLNH.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formNHTS,
            this.formNHCN});
            this.formQLNH.Name = "formQLNH";
            this.formQLNH.Size = new System.Drawing.Size(144, 22);
            this.formQLNH.Text = "Quản lý nhập hàng";
            // 
            // formNHTS
            // 
            this.formNHTS.AccessibleDescription = "z";
            this.formNHTS.Name = "formNHTS";
            this.formNHTS.Size = new System.Drawing.Size(214, 22);
            this.formNHTS.Text = "Nhập hàng trụ sở";
            // 
            // formNHCN
            // 
            this.formNHCN.AccessibleDescription = "z";
            this.formNHCN.Name = "formNHCN";
            this.formNHCN.Size = new System.Drawing.Size(214, 22);
            this.formNHCN.Text = "Nhập hàng chi nhánh";
            // 
            // formThongke
            // 
            this.formThongke.AccessibleDescription = "z";
            this.formThongke.Name = "formThongke";
            this.formThongke.Size = new System.Drawing.Size(82, 22);
            this.formThongke.Text = "Thống kê";
            this.formThongke.Click += new System.EventHandler(this.formThongke_Click);
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.AccessibleDescription = "";
            this.quanLyTaiKhoanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.formDoiMK,
            this.formQLTK});
            this.quanLyTaiKhoanToolStripMenuItem.Name = "quanLyTaiKhoanToolStripMenuItem";
            this.quanLyTaiKhoanToolStripMenuItem.Size = new System.Drawing.Size(134, 22);
            this.quanLyTaiKhoanToolStripMenuItem.Text = "Quản lý tài khoản";
            // 
            // formDoiMK
            // 
            this.formDoiMK.AccessibleDescription = "";
            this.formDoiMK.Name = "formDoiMK";
            this.formDoiMK.Size = new System.Drawing.Size(190, 22);
            this.formDoiMK.Text = "Đổi mật khẩu";
            this.formDoiMK.Click += new System.EventHandler(this.formDoiMK_Click);
            // 
            // formQLTK
            // 
            this.formQLTK.AccessibleDescription = "";
            this.formQLTK.Name = "formQLTK";
            this.formQLTK.Size = new System.Drawing.Size(190, 22);
            this.formQLTK.Text = "Quản lý tài khoản";
            this.formQLTK.Click += new System.EventHandler(this.formQLTK_Click);
            // 
            // lblQuyen
            // 
            this.lblQuyen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQuyen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuyen.Location = new System.Drawing.Point(775, 3);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(357, 23);
            this.lblQuyen.TabIndex = 71;
            this.lblQuyen.Text = "Giám đốc";
            this.lblQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GUI_LichSuGia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtNgayHieuLuc);
            this.Controls.Add(this.lstLSG);
            this.Controls.Add(this.cboTenSP);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtGia);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_LichSuGia";
            this.Text = "Lich su gia";
            this.Load += new System.EventHandler(this.GUI_LichSuGia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstLSG)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboTenSP;
        private System.Windows.Forms.DataGridView lstLSG;
        private System.Windows.Forms.DateTimePicker txtNgayHieuLuc;
        private System.Windows.Forms.Button btnLogout;
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
        private System.Windows.Forms.Label lblQuyen;
    }
}