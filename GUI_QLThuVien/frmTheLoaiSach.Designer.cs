namespace GUI_QLThuVien
{
    partial class frmTheLoaiSach
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTheLoaiSach));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            ngaytaodt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            label3 = new Label();
            guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            rdoKhongHoatDong = new Guna.UI2.WinForms.Guna2RadioButton();
            rdoHoatDong = new Guna.UI2.WinForms.Guna2RadioButton();
            label7 = new Label();
            btnLamMoi = new Guna.UI2.WinForms.Guna2Button();
            btnSua = new Guna.UI2.WinForms.Guna2Button();
            btnXoa = new Guna.UI2.WinForms.Guna2Button();
            btnThem = new Guna.UI2.WinForms.Guna2Button();
            txtTenTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            txtMaTheLoai = new Guna.UI2.WinForms.Guna2TextBox();
            label1 = new Label();
            panel2 = new Panel();
            txtTimKiem = new Guna.UI2.WinForms.Guna2TextBox();
            dgvTheLoaiSach = new Guna.UI2.WinForms.Guna2DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            sqlCommand2 = new Microsoft.Data.SqlClient.SqlCommand();
            panel1.SuspendLayout();
            guna2Panel2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ngaytaodt);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(guna2Panel2);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnLamMoi);
            panel1.Controls.Add(btnSua);
            panel1.Controls.Add(btnXoa);
            panel1.Controls.Add(btnThem);
            panel1.Controls.Add(txtTenTheLoai);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtMaTheLoai);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(364, 884);
            panel1.TabIndex = 71;
            // 
            // ngaytaodt
            // 
            ngaytaodt.Checked = true;
            ngaytaodt.CustomizableEdges = customizableEdges1;
            ngaytaodt.Font = new Font("Segoe UI", 9F);
            ngaytaodt.Format = DateTimePickerFormat.Long;
            ngaytaodt.Location = new Point(9, 434);
            ngaytaodt.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            ngaytaodt.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            ngaytaodt.Name = "ngaytaodt";
            ngaytaodt.ShadowDecoration.CustomizableEdges = customizableEdges2;
            ngaytaodt.Size = new Size(336, 60);
            ngaytaodt.TabIndex = 100;
            ngaytaodt.Value = new DateTime(2025, 6, 9, 11, 33, 43, 463);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(64, 0, 0);
            label3.Location = new Point(17, 398);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 99;
            label3.Text = "Ngày Tạo";
            // 
            // guna2Panel2
            // 
            guna2Panel2.Controls.Add(rdoKhongHoatDong);
            guna2Panel2.Controls.Add(rdoHoatDong);
            guna2Panel2.CustomizableEdges = customizableEdges3;
            guna2Panel2.Location = new Point(9, 297);
            guna2Panel2.Name = "guna2Panel2";
            guna2Panel2.ShadowDecoration.CustomizableEdges = customizableEdges4;
            guna2Panel2.Size = new Size(336, 55);
            guna2Panel2.TabIndex = 98;
            // 
            // rdoKhongHoatDong
            // 
            rdoKhongHoatDong.AutoSize = true;
            rdoKhongHoatDong.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rdoKhongHoatDong.CheckedState.BorderThickness = 0;
            rdoKhongHoatDong.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rdoKhongHoatDong.CheckedState.InnerColor = Color.White;
            rdoKhongHoatDong.CheckedState.InnerOffset = -4;
            rdoKhongHoatDong.Location = new Point(225, 17);
            rdoKhongHoatDong.Name = "rdoKhongHoatDong";
            rdoKhongHoatDong.Size = new Size(97, 24);
            rdoKhongHoatDong.TabIndex = 1;
            rdoKhongHoatDong.Text = "Tạm Khóa";
            rdoKhongHoatDong.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rdoKhongHoatDong.UncheckedState.BorderThickness = 2;
            rdoKhongHoatDong.UncheckedState.FillColor = Color.Transparent;
            rdoKhongHoatDong.UncheckedState.InnerColor = Color.Transparent;
            // 
            // rdoHoatDong
            // 
            rdoHoatDong.AutoSize = true;
            rdoHoatDong.Checked = true;
            rdoHoatDong.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            rdoHoatDong.CheckedState.BorderThickness = 0;
            rdoHoatDong.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            rdoHoatDong.CheckedState.InnerColor = Color.White;
            rdoHoatDong.CheckedState.InnerOffset = -4;
            rdoHoatDong.Location = new Point(12, 17);
            rdoHoatDong.Name = "rdoHoatDong";
            rdoHoatDong.Size = new Size(104, 24);
            rdoHoatDong.TabIndex = 0;
            rdoHoatDong.TabStop = true;
            rdoHoatDong.Text = "Hoạt Động";
            rdoHoatDong.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            rdoHoatDong.UncheckedState.BorderThickness = 2;
            rdoHoatDong.UncheckedState.FillColor = Color.Transparent;
            rdoHoatDong.UncheckedState.InnerColor = Color.Transparent;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = Color.FromArgb(64, 0, 0);
            label7.Location = new Point(17, 270);
            label7.Name = "label7";
            label7.Size = new Size(78, 20);
            label7.TabIndex = 97;
            label7.Text = "Trạng Thái";
            // 
            // btnLamMoi
            // 
            btnLamMoi.BorderRadius = 10;
            btnLamMoi.CustomizableEdges = customizableEdges5;
            btnLamMoi.DisabledState.BorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.CustomBorderColor = Color.DarkGray;
            btnLamMoi.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnLamMoi.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnLamMoi.Font = new Font("Segoe UI", 9F);
            btnLamMoi.ForeColor = Color.White;
            btnLamMoi.Location = new Point(211, 644);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.ShadowDecoration.CustomizableEdges = customizableEdges6;
            btnLamMoi.Size = new Size(103, 56);
            btnLamMoi.TabIndex = 96;
            btnLamMoi.Text = "Làm Mới";
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnSua
            // 
            btnSua.BorderRadius = 10;
            btnSua.CustomizableEdges = customizableEdges7;
            btnSua.DisabledState.BorderColor = Color.DarkGray;
            btnSua.DisabledState.CustomBorderColor = Color.DarkGray;
            btnSua.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnSua.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnSua.Font = new Font("Segoe UI", 9F);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(211, 554);
            btnSua.Name = "btnSua";
            btnSua.ShadowDecoration.CustomizableEdges = customizableEdges8;
            btnSua.Size = new Size(103, 56);
            btnSua.TabIndex = 95;
            btnSua.Text = "Sửa";
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BorderRadius = 10;
            btnXoa.CustomizableEdges = customizableEdges9;
            btnXoa.DisabledState.BorderColor = Color.DarkGray;
            btnXoa.DisabledState.CustomBorderColor = Color.DarkGray;
            btnXoa.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnXoa.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnXoa.Font = new Font("Segoe UI", 9F);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(34, 644);
            btnXoa.Name = "btnXoa";
            btnXoa.ShadowDecoration.CustomizableEdges = customizableEdges10;
            btnXoa.Size = new Size(103, 56);
            btnXoa.TabIndex = 94;
            btnXoa.Text = "Xóa";
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BorderRadius = 10;
            btnThem.CustomizableEdges = customizableEdges11;
            btnThem.DisabledState.BorderColor = Color.DarkGray;
            btnThem.DisabledState.CustomBorderColor = Color.DarkGray;
            btnThem.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            btnThem.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            btnThem.Font = new Font("Segoe UI", 9F);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(34, 554);
            btnThem.Name = "btnThem";
            btnThem.ShadowDecoration.CustomizableEdges = customizableEdges12;
            btnThem.Size = new Size(103, 56);
            btnThem.TabIndex = 93;
            btnThem.Text = "Thêm";
            btnThem.Click += btnThem_Click;
            // 
            // txtTenTheLoai
            // 
            txtTenTheLoai.BorderRadius = 5;
            txtTenTheLoai.CustomizableEdges = customizableEdges13;
            txtTenTheLoai.DefaultText = "";
            txtTenTheLoai.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTenTheLoai.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTenTheLoai.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTenTheLoai.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTenTheLoai.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenTheLoai.Font = new Font("Segoe UI", 9F);
            txtTenTheLoai.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTenTheLoai.Location = new Point(13, 188);
            txtTenTheLoai.Margin = new Padding(3, 4, 3, 4);
            txtTenTheLoai.Name = "txtTenTheLoai";
            txtTenTheLoai.PasswordChar = '\0';
            txtTenTheLoai.PlaceholderText = "";
            txtTenTheLoai.SelectedText = "";
            txtTenTheLoai.ShadowDecoration.CustomizableEdges = customizableEdges14;
            txtTenTheLoai.Size = new Size(332, 49);
            txtTenTheLoai.TabIndex = 91;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(64, 0, 0);
            label2.Location = new Point(9, 157);
            label2.Name = "label2";
            label2.Size = new Size(92, 20);
            label2.TabIndex = 90;
            label2.Text = "Tên Thể Loại";
            // 
            // txtMaTheLoai
            // 
            txtMaTheLoai.BorderRadius = 5;
            txtMaTheLoai.CustomizableEdges = customizableEdges15;
            txtMaTheLoai.DefaultText = "";
            txtMaTheLoai.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtMaTheLoai.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtMaTheLoai.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtMaTheLoai.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtMaTheLoai.Enabled = false;
            txtMaTheLoai.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTheLoai.Font = new Font("Segoe UI", 9F);
            txtMaTheLoai.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtMaTheLoai.Location = new Point(17, 96);
            txtMaTheLoai.Margin = new Padding(3, 4, 3, 4);
            txtMaTheLoai.Name = "txtMaTheLoai";
            txtMaTheLoai.PasswordChar = '\0';
            txtMaTheLoai.PlaceholderText = "";
            txtMaTheLoai.ReadOnly = true;
            txtMaTheLoai.SelectedText = "";
            txtMaTheLoai.ShadowDecoration.CustomizableEdges = customizableEdges16;
            txtMaTheLoai.Size = new Size(332, 49);
            txtMaTheLoai.TabIndex = 92;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(64, 0, 0);
            label1.Location = new Point(13, 65);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 89;
            label1.Text = "Mã Thể Loại";
            // 
            // panel2
            // 
            panel2.Controls.Add(txtTimKiem);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(364, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(895, 73);
            panel2.TabIndex = 72;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTimKiem.BorderRadius = 5;
            txtTimKiem.CustomizableEdges = customizableEdges17;
            txtTimKiem.DefaultText = "";
            txtTimKiem.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            txtTimKiem.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            txtTimKiem.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            txtTimKiem.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.Font = new Font("Segoe UI", 9F);
            txtTimKiem.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            txtTimKiem.IconLeftSize = new Size(40, 40);
            txtTimKiem.IconRight = (Image)resources.GetObject("txtTimKiem.IconRight");
            txtTimKiem.Location = new Point(521, 13);
            txtTimKiem.Margin = new Padding(3, 4, 3, 4);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.PasswordChar = '\0';
            txtTimKiem.PlaceholderText = "Tìm Kiếm";
            txtTimKiem.SelectedText = "";
            txtTimKiem.ShadowDecoration.CustomizableEdges = customizableEdges18;
            txtTimKiem.Size = new Size(362, 50);
            txtTimKiem.TabIndex = 71;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // dgvTheLoaiSach
            // 
            dataGridViewCellStyle1.BackColor = Color.White;
            dgvTheLoaiSach.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(100, 88, 255);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvTheLoaiSach.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvTheLoaiSach.ColumnHeadersHeight = 50;
            dgvTheLoaiSach.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvTheLoaiSach.DefaultCellStyle = dataGridViewCellStyle3;
            dgvTheLoaiSach.Dock = DockStyle.Fill;
            dgvTheLoaiSach.GridColor = Color.FromArgb(231, 229, 255);
            dgvTheLoaiSach.Location = new Point(364, 73);
            dgvTheLoaiSach.Name = "dgvTheLoaiSach";
            dgvTheLoaiSach.RowHeadersVisible = false;
            dgvTheLoaiSach.RowHeadersWidth = 51;
            dgvTheLoaiSach.Size = new Size(895, 811);
            dgvTheLoaiSach.TabIndex = 73;
            dgvTheLoaiSach.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White;
            dgvTheLoaiSach.ThemeStyle.AlternatingRowsStyle.Font = null;
            dgvTheLoaiSach.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            dgvTheLoaiSach.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            dgvTheLoaiSach.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            dgvTheLoaiSach.ThemeStyle.BackColor = Color.White;
            dgvTheLoaiSach.ThemeStyle.GridColor = Color.FromArgb(231, 229, 255);
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(100, 88, 255);
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F);
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dgvTheLoaiSach.ThemeStyle.HeaderStyle.Height = 50;
            dgvTheLoaiSach.ThemeStyle.ReadOnly = false;
            dgvTheLoaiSach.ThemeStyle.RowsStyle.BackColor = Color.White;
            dgvTheLoaiSach.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvTheLoaiSach.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F);
            dgvTheLoaiSach.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(71, 69, 94);
            dgvTheLoaiSach.ThemeStyle.RowsStyle.Height = 29;
            dgvTheLoaiSach.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(231, 229, 255);
            dgvTheLoaiSach.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(71, 69, 94);
            dgvTheLoaiSach.CellDoubleClick += dgvTheLoaiSach_CellDoubleClick;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // sqlCommand2
            // 
            sqlCommand2.CommandTimeout = 30;
            sqlCommand2.EnableOptimizedParameterBinding = false;
            // 
            // frmTheLoaiSach
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 884);
            Controls.Add(dgvTheLoaiSach);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmTheLoaiSach";
            Text = "frmTheLoaiSach";
            Load += frmTheLoaiSach_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            guna2Panel2.ResumeLayout(false);
            guna2Panel2.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvTheLoaiSach).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2RadioButton rdoKhongHoatDong;
        private Guna.UI2.WinForms.Guna2RadioButton rdoHoatDong;
        private Label label7;
        private Guna.UI2.WinForms.Guna2Button btnLamMoi;
        private Guna.UI2.WinForms.Guna2Button btnSua;
        private Guna.UI2.WinForms.Guna2Button btnXoa;
        private Guna.UI2.WinForms.Guna2Button btnThem;
        private Guna.UI2.WinForms.Guna2TextBox txtTenTheLoai;
        private Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaTheLoai;
        private Label label1;
        private Panel panel2;
        private Guna.UI2.WinForms.Guna2TextBox txtTimKiem;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTheLoaiSach;
        private Guna.UI2.WinForms.Guna2DateTimePicker ngaytaodt;
        private Label label3;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand2;
    }
}