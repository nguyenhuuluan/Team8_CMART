namespace CMART8
{
    partial class GUI_QLTK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GUI_QLTK));
            this.cboQuyen = new System.Windows.Forms.ComboBox();
            this.lstTK = new System.Windows.Forms.DataGridView();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.txtMK = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.txtCMND = new System.Windows.Forms.TextBox();
            this.txtTDN = new System.Windows.Forms.TextBox();
            this.editMK = new System.Windows.Forms.CheckBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.lstTK)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboQuyen
            // 
            this.cboQuyen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboQuyen.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboQuyen.FormattingEnabled = true;
            this.cboQuyen.Items.AddRange(new object[] {
            "Nhân viên bán hàng",
            "Quản lý chi nhánh",
            "Nhân viên kiểm kho",
            "Thư ký",
            "Giám đốc",
            "Admin"});
            this.cboQuyen.Location = new System.Drawing.Point(169, 453);
            this.cboQuyen.Name = "cboQuyen";
            this.cboQuyen.Size = new System.Drawing.Size(310, 32);
            this.cboQuyen.TabIndex = 8;
            // 
            // lstTK
            // 
            this.lstTK.AllowUserToAddRows = false;
            this.lstTK.AllowUserToDeleteRows = false;
            this.lstTK.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.lstTK.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.lstTK.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.lstTK.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.lstTK.DefaultCellStyle = dataGridViewCellStyle2;
            this.lstTK.Location = new System.Drawing.Point(521, 163);
            this.lstTK.Name = "lstTK";
            this.lstTK.ReadOnly = true;
            this.lstTK.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.lstTK.Size = new System.Drawing.Size(660, 360);
            this.lstTK.TabIndex = 100;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Enabled = false;
            this.txtDiaChi.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiaChi.Location = new System.Drawing.Point(170, 210);
            this.txtDiaChi.Multiline = true;
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(310, 32);
            this.txtDiaChi.TabIndex = 2;
            // 
            // txtSDT
            // 
            this.txtSDT.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSDT.Location = new System.Drawing.Point(170, 257);
            this.txtSDT.Multiline = true;
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(310, 32);
            this.txtSDT.TabIndex = 3;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(6, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(162, 25);
            this.label11.TabIndex = 82;
            this.label11.Text = "Tên đăng nhập:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(6, 453);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 25);
            this.label12.TabIndex = 78;
            this.label12.Text = "Quyền:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Black;
            this.label13.Location = new System.Drawing.Point(6, 217);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 25);
            this.label13.TabIndex = 76;
            this.label13.Text = "Địa chỉ:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::CMART8.Properties.Resources.find2;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSearch.Location = new System.Drawing.Point(1141, 110);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 40);
            this.btnSearch.TabIndex = 72;
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::CMART8.Properties.Resources.delete;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelete.Location = new System.Drawing.Point(614, 45);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 65);
            this.btnDelete.TabIndex = 71;
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.BackgroundImage = global::CMART8.Properties.Resources.Edit2;
            this.btnEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEdit.Location = new System.Drawing.Point(337, 45);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(72, 65);
            this.btnEdit.TabIndex = 70;
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::CMART8.Properties.Resources.Add;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(76, 45);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(72, 65);
            this.btnAdd.TabIndex = 73;
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(206, 509);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 43);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(347, 509);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 43);
            this.btnSave.TabIndex = 9;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Enabled = false;
            this.button6.Location = new System.Drawing.Point(11, 153);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(1170, 4);
            this.button6.TabIndex = 94;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(242, 32);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(4, 118);
            this.button7.TabIndex = 93;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(758, 32);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(4, 118);
            this.button8.TabIndex = 92;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Enabled = false;
            this.button11.Location = new System.Drawing.Point(511, 163);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(4, 360);
            this.button11.TabIndex = 91;
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(534, 32);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(4, 118);
            this.button5.TabIndex = 90;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // txtMK
            // 
            this.txtMK.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMK.Location = new System.Drawing.Point(169, 404);
            this.txtMK.Multiline = true;
            this.txtMK.Name = "txtMK";
            this.txtMK.PasswordChar = '*';
            this.txtMK.Size = new System.Drawing.Size(311, 32);
            this.txtMK.TabIndex = 7;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Silver;
            this.txtSearch.Location = new System.Drawing.Point(811, 110);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 40);
            this.txtSearch.TabIndex = 86;
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
            this.label4.Location = new System.Drawing.Point(959, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 33);
            this.label4.TabIndex = 85;
            this.label4.Text = "Quản lý tài khoản";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Maroon;
            this.label3.Location = new System.Drawing.Point(592, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 83;
            this.label3.Text = "Xóa tài khoản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(6, 312);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 25);
            this.label7.TabIndex = 81;
            this.label7.Text = "CMND:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Maroon;
            this.label2.Location = new System.Drawing.Point(272, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 23);
            this.label2.TabIndex = 80;
            this.label2.Text = "Sửa thông tin tài khoản";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(6, 410);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Mật khẩu:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(6, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "SĐT:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(6, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 25);
            this.label5.TabIndex = 75;
            this.label5.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(38, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 23);
            this.label1.TabIndex = 74;
            this.label1.Text = "Thêm mới tài khoản";
            // 
            // txtTen
            // 
            this.txtTen.Enabled = false;
            this.txtTen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Location = new System.Drawing.Point(170, 163);
            this.txtTen.Multiline = true;
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(310, 32);
            this.txtTen.TabIndex = 1;
            // 
            // txtCMND
            // 
            this.txtCMND.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCMND.Location = new System.Drawing.Point(169, 305);
            this.txtCMND.Multiline = true;
            this.txtCMND.Name = "txtCMND";
            this.txtCMND.Size = new System.Drawing.Size(310, 32);
            this.txtCMND.TabIndex = 4;
            // 
            // txtTDN
            // 
            this.txtTDN.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTDN.Location = new System.Drawing.Point(170, 353);
            this.txtTDN.Multiline = true;
            this.txtTDN.Name = "txtTDN";
            this.txtTDN.Size = new System.Drawing.Size(310, 32);
            this.txtTDN.TabIndex = 5;
            // 
            // editMK
            // 
            this.editMK.AutoSize = true;
            this.editMK.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.editMK.Location = new System.Drawing.Point(104, 419);
            this.editMK.Name = "editMK";
            this.editMK.Size = new System.Drawing.Size(44, 17);
            this.editMK.TabIndex = 6;
            this.editMK.Text = "Edit";
            this.editMK.UseVisualStyleBackColor = true;
            this.editMK.CheckedChanged += new System.EventHandler(this.editMK_CheckedChanged);
            // 
            // btnLogout
            // 
            this.btnLogout.BackgroundImage = global::CMART8.Properties.Resources.Logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.Location = new System.Drawing.Point(1132, 0);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(49, 26);
            this.btnLogout.TabIndex = 103;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
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
            this.menuStrip1.Size = new System.Drawing.Size(1187, 26);
            this.menuStrip1.TabIndex = 101;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // formQLHD
            // 
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
            this.quảnLýSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýLoạiSảnPhẩmToolStripMenuItem
            // 
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Name = "quảnLýLoạiSảnPhẩmToolStripMenuItem";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Text = "Loại sản phẩm";
            this.quảnLýLoạiSảnPhẩmToolStripMenuItem.Click += new System.EventHandler(this.quảnLýLoạiSảnPhẩmToolStripMenuItem_Click);
            // 
            // quảnLýNhàToolStripMenuItem
            // 
            this.quảnLýNhàToolStripMenuItem.Name = "quảnLýNhàToolStripMenuItem";
            this.quảnLýNhàToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.quảnLýNhàToolStripMenuItem.Text = "Nhà cung cấp";
            this.quảnLýNhàToolStripMenuItem.Click += new System.EventHandler(this.quảnLýNhàToolStripMenuItem_Click);
            // 
            // thôngTinKhuyếnMãiToolStripMenuItem
            // 
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
            this.formLSG.Click += new System.EventHandler(this.formLSG_Click);
            // 
            // formQLNH
            // 
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
            this.formThongke.Click += new System.EventHandler(this.formThongke_Click);
            // 
            // quanLyTaiKhoanToolStripMenuItem
            // 
            this.quanLyTaiKhoanToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
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
            // 
            // formQLTK
            // 
            this.formQLTK.Name = "formQLTK";
            this.formQLTK.Size = new System.Drawing.Size(190, 22);
            this.formQLTK.Text = "Quản lý tài khoản";
            // 
            // lblQuyen
            // 
            this.lblQuyen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lblQuyen.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuyen.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblQuyen.Location = new System.Drawing.Point(848, 3);
            this.lblQuyen.Name = "lblQuyen";
            this.lblQuyen.Size = new System.Drawing.Size(282, 23);
            this.lblQuyen.TabIndex = 104;
            this.lblQuyen.Text = "Giám đốc";
            this.lblQuyen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // GUI_QLTK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 564);
            this.Controls.Add(this.lblQuyen);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.editMK);
            this.Controls.Add(this.cboQuyen);
            this.Controls.Add(this.lstTK);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTDN);
            this.Controls.Add(this.txtCMND);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.txtMK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GUI_QLTK";
            this.Text = "Quan ly tai khoan";
            this.Load += new System.EventHandler(this.GUI_QLTK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lstTK)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboQuyen;
        private System.Windows.Forms.DataGridView lstTK;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox txtMK;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.TextBox txtCMND;
        private System.Windows.Forms.TextBox txtTDN;
        private System.Windows.Forms.CheckBox editMK;
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