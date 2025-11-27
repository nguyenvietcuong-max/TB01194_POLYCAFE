namespace POLY_CAFE
{
    partial class frmNhanVien
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            groupBox1 = new GroupBox();
            rbQuanLy = new RadioButton();
            rbNhanVien = new RadioButton();
            panel2 = new Panel();
            rbDeActive = new RadioButton();
            rbActive = new RadioButton();
            label8 = new Label();
            txtXacNhanMK = new TextBox();
            txtMatKhau = new TextBox();
            txtEmail = new TextBox();
            txtHoTen = new TextBox();
            txtMaNhanVien = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dgvDanhSachNhanVien = new Guna.UI2.WinForms.Guna2DataGridView();
            panel1 = new Panel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 23F);
            label1.Location = new Point(509, 19);
            label1.Name = "label1";
            label1.Size = new Size(180, 42);
            label1.TabIndex = 0;
            label1.Text = "NHÂN VIÊN";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbQuanLy);
            groupBox1.Controls.Add(rbNhanVien);
            groupBox1.Controls.Add(panel2);
            groupBox1.Controls.Add(txtXacNhanMK);
            groupBox1.Controls.Add(txtMatKhau);
            groupBox1.Controls.Add(txtEmail);
            groupBox1.Controls.Add(txtHoTen);
            groupBox1.Controls.Add(txtMaNhanVien);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 64);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(355, 374);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Nhân Viên";
            // 
            // rbQuanLy
            // 
            rbQuanLy.AutoSize = true;
            rbQuanLy.Location = new Point(252, 269);
            rbQuanLy.Name = "rbQuanLy";
            rbQuanLy.Size = new Size(68, 19);
            rbQuanLy.TabIndex = 14;
            rbQuanLy.TabStop = true;
            rbQuanLy.Text = "Quản Lý";
            rbQuanLy.UseVisualStyleBackColor = true;
            // 
            // rbNhanVien
            // 
            rbNhanVien.AutoSize = true;
            rbNhanVien.Location = new Point(124, 271);
            rbNhanVien.Name = "rbNhanVien";
            rbNhanVien.Size = new Size(80, 19);
            rbNhanVien.TabIndex = 13;
            rbNhanVien.TabStop = true;
            rbNhanVien.Text = "Nhân Viên";
            rbNhanVien.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(rbDeActive);
            panel2.Controls.Add(rbActive);
            panel2.Controls.Add(label8);
            panel2.Location = new Point(0, 296);
            panel2.Name = "panel2";
            panel2.Size = new Size(355, 43);
            panel2.TabIndex = 12;
            // 
            // rbDeActive
            // 
            rbDeActive.AutoSize = true;
            rbDeActive.Location = new Point(252, 10);
            rbDeActive.Name = "rbDeActive";
            rbDeActive.Size = new Size(89, 19);
            rbDeActive.TabIndex = 8;
            rbDeActive.TabStop = true;
            rbDeActive.Text = "Tạm Ngưng";
            rbDeActive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Location = new Point(124, 10);
            rbActive.Name = "rbActive";
            rbActive.Size = new Size(114, 19);
            rbActive.TabIndex = 7;
            rbActive.TabStop = true;
            rbActive.Text = "Đang Hoạt Động";
            rbActive.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(6, 14);
            label8.Name = "label8";
            label8.Size = new Size(63, 15);
            label8.TabIndex = 6;
            label8.Text = "Trạng Thái";
            label8.Click += label8_Click;
            // 
            // txtXacNhanMK
            // 
            txtXacNhanMK.Location = new Point(124, 200);
            txtXacNhanMK.Name = "txtXacNhanMK";
            txtXacNhanMK.Size = new Size(222, 23);
            txtXacNhanMK.TabIndex = 11;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(124, 154);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.Size = new Size(222, 23);
            txtMatKhau.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(124, 111);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(222, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtHoTen
            // 
            txtHoTen.Location = new Point(124, 69);
            txtHoTen.Name = "txtHoTen";
            txtHoTen.Size = new Size(222, 23);
            txtHoTen.TabIndex = 8;
            // 
            // txtMaNhanVien
            // 
            txtMaNhanVien.Location = new Point(124, 35);
            txtMaNhanVien.Name = "txtMaNhanVien";
            txtMaNhanVien.Size = new Size(222, 23);
            txtMaNhanVien.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(6, 273);
            label7.Name = "label7";
            label7.Size = new Size(42, 15);
            label7.TabIndex = 5;
            label7.Text = "Vai Trò";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 208);
            label6.Name = "label6";
            label6.Size = new Size(112, 15);
            label6.TabIndex = 4;
            label6.Text = "Xác Nhận Mật Khẩu";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 162);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 3;
            label5.Text = "Mật Khẩu";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 119);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 2;
            label4.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 77);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 35);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 0;
            label2.Text = "Mã Nhân Viên";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dgvDanhSachNhanVien);
            groupBox2.Controls.Add(panel1);
            groupBox2.Location = new Point(373, 64);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(322, 374);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Nhân Viên";
            // 
            // dgvDanhSachNhanVien
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvDanhSachNhanVien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvDanhSachNhanVien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvDanhSachNhanVien.ColumnHeadersHeight = 50;
            dgvDanhSachNhanVien.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvDanhSachNhanVien.DefaultCellStyle = dataGridViewCellStyle3;
            dgvDanhSachNhanVien.Dock = DockStyle.Fill;
            dgvDanhSachNhanVien.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachNhanVien.Location = new Point(3, 119);
            dgvDanhSachNhanVien.Name = "dgvDanhSachNhanVien";
            dgvDanhSachNhanVien.RowHeadersVisible = false;
            dgvDanhSachNhanVien.Size = new Size(316, 252);
            dgvDanhSachNhanVien.TabIndex = 1;
            dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvDanhSachNhanVien.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvDanhSachNhanVien.ThemeStyle.BackColor = Color.White;
            dgvDanhSachNhanVien.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvDanhSachNhanVien.ThemeStyle.HeaderStyle.Height = 50;
            dgvDanhSachNhanVien.ThemeStyle.ReadOnly = false;
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.Height = 25;
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvDanhSachNhanVien.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            // 
            // panel1
            // 
            panel1.Controls.Add(txtTimKiem);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(3, 19);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 100);
            panel1.TabIndex = 0;
            // 
            // txtTimKiem
            // 
            txtTimKiem.CustomizableEdges = customizableEdges1;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Location = new Point(113, 3);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges2;
            txtTimKiem.Size = new Size(200, 36);
            txtTimKiem.TabIndex = 0;
            // 
            // frmNhanVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "frmNhanVien";
            Text = "frmNhanVien";
            Load += frmNhanVien_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDanhSachNhanVien).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhSachNhanVien;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private TextBox txtXacNhanMK;
        private TextBox txtMatKhau;
        private TextBox txtEmail;
        private TextBox txtHoTen;
        private TextBox txtMaNhanVien;
        private Panel panel2;
        private RadioButton rbQuanLy;
        private RadioButton rbNhanVien;
        private RadioButton rbDeActive;
        private RadioButton rbActive;
    }
}