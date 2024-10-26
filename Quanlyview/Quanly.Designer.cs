namespace Quanlyview
{
    partial class Quanly
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
            btThoat = new Button();
            btDangXuat = new Button();
            dgvEmployee = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            tbId = new TextBox();
            tbName = new TextBox();
            ckGender = new CheckBox();
            btAddNew = new Button();
            btEdit = new Button();
            btDelete = new Button();
            label5 = new Label();
            tbAddress = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cbKhoaHoc = new ComboBox();
            tbMaLopHoc = new TextBox();
            pbEmployeeImage = new PictureBox();
            btSelectImage = new Button();
            dateTimePicker1 = new DateTimePicker();
            Sodienthoai = new Label();
            tbPhone = new TextBox();
            label9 = new Label();
            tbEmail = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).BeginInit();
            SuspendLayout();
            // 
            // btThoat
            // 
            btThoat.Location = new Point(513, 481);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(47, 24);
            btThoat.TabIndex = 0;
            btThoat.Text = "Thoát";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // btDangXuat
            // 
            btDangXuat.Location = new Point(398, 481);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(80, 24);
            btDangXuat.TabIndex = 1;
            btDangXuat.Text = "Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = true;
            btDangXuat.Click += btDangXuat_Click;
            // 
            // dgvEmployee
            // 
            dgvEmployee.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEmployee.Location = new Point(12, 81);
            dgvEmployee.Name = "dgvEmployee";
            dgvEmployee.RowHeadersWidth = 51;
            dgvEmployee.Size = new Size(788, 147);
            dgvEmployee.TabIndex = 2;
            dgvEmployee.RowEnter += dgvEmployee_RowEnter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(362, 237);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 3;
            label1.Text = "Mã Sinh Viên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(362, 271);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Họ và Tên";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(362, 311);
            label3.Name = "label3";
            label3.Size = new Size(59, 15);
            label3.TabIndex = 5;
            label3.Text = "Năm Sinh";
            // 
            // tbId
            // 
            tbId.Location = new Point(444, 234);
            tbId.Name = "tbId";
            tbId.Size = new Size(146, 23);
            tbId.TabIndex = 6;
            tbId.TextChanged += tbId_TextChanged;
            // 
            // tbName
            // 
            tbName.Location = new Point(444, 271);
            tbName.Name = "tbName";
            tbName.Size = new Size(146, 23);
            tbName.TabIndex = 8;
            tbName.TextChanged += tbName_TextChanged;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Checked;
            ckGender.Location = new Point(444, 350);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(52, 19);
            ckGender.TabIndex = 9;
            ckGender.Text = "Nam";
            ckGender.UseVisualStyleBackColor = true;
            // 
            // btAddNew
            // 
            btAddNew.Location = new Point(20, 41);
            btAddNew.Name = "btAddNew";
            btAddNew.Size = new Size(49, 30);
            btAddNew.TabIndex = 10;
            btAddNew.UseVisualStyleBackColor = true;
            btAddNew.Click += btAddNew_Click;
            // 
            // btEdit
            // 
            btEdit.Location = new Point(219, 41);
            btEdit.Name = "btEdit";
            btEdit.Size = new Size(49, 30);
            btEdit.TabIndex = 11;
            btEdit.UseVisualStyleBackColor = true;
            btEdit.Click += btEdit_Click;
            // 
            // btDelete
            // 
            btDelete.Location = new Point(111, 41);
            btDelete.Name = "btDelete";
            btDelete.Size = new Size(49, 30);
            btDelete.TabIndex = 12;
            btDelete.UseVisualStyleBackColor = true;
            btDelete.Click += btDelete_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15F);
            label5.Location = new Point(219, 4);
            label5.Name = "label5";
            label5.Size = new Size(165, 28);
            label5.TabIndex = 13;
            label5.Text = "Quản lý Sinh Viên";
            label5.Click += label5_Click;
            // 
            // tbAddress
            // 
            tbAddress.Location = new Point(111, 237);
            tbAddress.Name = "tbAddress";
            tbAddress.Size = new Size(210, 23);
            tbAddress.TabIndex = 14;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 316);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 17;
            label6.Text = "Mã Lớp Học";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(20, 279);
            label7.Name = "label7";
            label7.Size = new Size(59, 15);
            label7.TabIndex = 18;
            label7.Text = "Khoa Học";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(20, 240);
            label8.Name = "label8";
            label8.Size = new Size(52, 15);
            label8.TabIndex = 19;
            label8.Text = "Nơi SInh";
            // 
            // cbKhoaHoc
            // 
            cbKhoaHoc.FormattingEnabled = true;
            cbKhoaHoc.Items.AddRange(new object[] { "Công Nghệ Thông Tin", "Quản Trị Kinh Doanh", "Điện Công Nghiệp", "Điện Lạnh" });
            cbKhoaHoc.Location = new Point(111, 271);
            cbKhoaHoc.Name = "cbKhoaHoc";
            cbKhoaHoc.Size = new Size(210, 23);
            cbKhoaHoc.TabIndex = 20;
            cbKhoaHoc.SelectedIndexChanged += cbMaphongban_SelectedIndexChanged;
            // 
            // tbMaLopHoc
            // 
            tbMaLopHoc.Location = new Point(111, 313);
            tbMaLopHoc.Name = "tbMaLopHoc";
            tbMaLopHoc.Size = new Size(210, 23);
            tbMaLopHoc.TabIndex = 21;
            tbMaLopHoc.TextChanged += tbMaduan_TextChanged;
            // 
            // pbEmployeeImage
            // 
            pbEmployeeImage.Location = new Point(152, 407);
            pbEmployeeImage.Name = "pbEmployeeImage";
            pbEmployeeImage.Size = new Size(79, 80);
            pbEmployeeImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbEmployeeImage.TabIndex = 22;
            pbEmployeeImage.TabStop = false;
            // 
            // btSelectImage
            // 
            btSelectImage.Location = new Point(65, 363);
            btSelectImage.Name = "btSelectImage";
            btSelectImage.Size = new Size(95, 25);
            btSelectImage.TabIndex = 23;
            btSelectImage.Text = "Chọn ảnh...";
            btSelectImage.UseVisualStyleBackColor = true;
            btSelectImage.Click += btSelectImage_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(444, 305);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(146, 23);
            dateTimePicker1.TabIndex = 24;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Sodienthoai
            // 
            Sodienthoai.AutoSize = true;
            Sodienthoai.Location = new Point(362, 379);
            Sodienthoai.Name = "Sodienthoai";
            Sodienthoai.Size = new Size(79, 15);
            Sodienthoai.TabIndex = 25;
            Sodienthoai.Text = "Số Điện Thoại";
            Sodienthoai.Click += label4_Click;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(447, 379);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(143, 23);
            tbPhone.TabIndex = 26;
            tbPhone.TextChanged += tbPhone_TextChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(362, 420);
            label9.Name = "label9";
            label9.Size = new Size(36, 15);
            label9.TabIndex = 27;
            label9.Text = "Email";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(447, 417);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(143, 23);
            tbEmail.TabIndex = 28;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // Quanly
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            ClientSize = new Size(827, 517);
            Controls.Add(tbEmail);
            Controls.Add(label9);
            Controls.Add(tbPhone);
            Controls.Add(Sodienthoai);
            Controls.Add(dateTimePicker1);
            Controls.Add(btSelectImage);
            Controls.Add(pbEmployeeImage);
            Controls.Add(tbMaLopHoc);
            Controls.Add(cbKhoaHoc);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(tbAddress);
            Controls.Add(label5);
            Controls.Add(btDelete);
            Controls.Add(btEdit);
            Controls.Add(btAddNew);
            Controls.Add(ckGender);
            Controls.Add(tbName);
            Controls.Add(tbId);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgvEmployee);
            Controls.Add(btDangXuat);
            Controls.Add(btThoat);
            Name = "Quanly";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quanly";
            FormClosed += Quanly_FormClosed;
            Load += Quanly_Load;
            ((System.ComponentModel.ISupportInitialize)dgvEmployee).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbEmployeeImage).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btThoat;
        private Button btDangXuat;
        private DataGridView dgvEmployee;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbId;
        private TextBox tbName;
        private CheckBox ckGender;
        private Button btAddNew;
        private Button btEdit;
        private Button btDelete;
        private Label label5;
        private TextBox tbAddress;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cbKhoaHoc;
        private TextBox tbMaLopHoc;
        private PictureBox pbEmployeeImage;
        private Button btSelectImage;
        private DateTimePicker dateTimePicker1;
        private Label Sodienthoai;
        private TextBox tbPhone;
        private Label label9;
        private TextBox tbEmail;
    }
}