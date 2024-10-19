namespace Quanlyview
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbTaiKhoan = new TextBox();
            tbMatKhau = new TextBox();
            btDangNhap = new Button();
            btThoat = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 32);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 0;
            label1.Text = "Login Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 75);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 1;
            label2.Text = "Password";
            label2.Click += label2_Click;
            // 
            // tbTaiKhoan
            // 
            tbTaiKhoan.Location = new Point(103, 29);
            tbTaiKhoan.Name = "tbTaiKhoan";
            tbTaiKhoan.Size = new Size(124, 23);
            tbTaiKhoan.TabIndex = 2;
            tbTaiKhoan.TextChanged += tbTaiKhoan_TextChanged;
            // 
            // tbMatKhau
            // 
            tbMatKhau.Location = new Point(103, 72);
            tbMatKhau.Name = "tbMatKhau";
            tbMatKhau.Size = new Size(122, 23);
            tbMatKhau.TabIndex = 3;
            tbMatKhau.UseSystemPasswordChar = true;
            tbMatKhau.TextChanged += tbMatKhau_TextChanged;
            // 
            // btDangNhap
            // 
            btDangNhap.Location = new Point(12, 137);
            btDangNhap.Name = "btDangNhap";
            btDangNhap.Size = new Size(99, 33);
            btDangNhap.TabIndex = 4;
            btDangNhap.Text = "Login";
            btDangNhap.UseVisualStyleBackColor = true;
            btDangNhap.Click += btDangNhap_Click;
            // 
            // btThoat
            // 
            btThoat.Location = new Point(128, 137);
            btThoat.Name = "btThoat";
            btThoat.Size = new Size(99, 33);
            btThoat.TabIndex = 5;
            btThoat.Text = "Exit";
            btThoat.UseVisualStyleBackColor = true;
            btThoat.Click += btThoat_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(103, 101);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 173);
            Controls.Add(checkBox1);
            Controls.Add(btThoat);
            Controls.Add(btDangNhap);
            Controls.Add(tbMatKhau);
            Controls.Add(tbTaiKhoan);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbTaiKhoan;
        private TextBox tbMatKhau;
        private Button btDangNhap;
        private Button btThoat;
        private CheckBox checkBox1;
    }
}
