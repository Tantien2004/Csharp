﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing; // Ensure you have this using directive for Image

namespace Quanlyview
{
    public partial class Quanly : Form
    {
        public List<Employee> lstEmp = new List<Employee>();
        private BindingSource bs = new BindingSource();
        public bool isThoat = true;
        public event EventHandler DangXuat;

        private string employeeImagePath = string.Empty; // Store the image path

        public Quanly()
        {
            InitializeComponent();
            SetupImageList();

            //ngay sinh
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd MMMM yyyy";
            // Handle value changes (optional)
            dateTimePicker1.ShowUpDown = true;
        }

        private void Quanly_Load(object sender, EventArgs e)
        {
            lstEmp = GetData();
            bs.DataSource = lstEmp;
            dgvEmployee.DataSource = bs;
            SetupDataGridView(); // Setup DataGridView columns
            dateTimePicker1.Value = DateTime.Now; // Set the default date to now

        }

        public List<Employee> GetData()
        {
            // Sample data can be added here if needed
            return lstEmp;
        }

        private void SetupDataGridView()
        {
            dgvEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEmployee.Columns[0].HeaderText = "Mã";
            dgvEmployee.Columns[1].HeaderText = "Tên";
            dgvEmployee.Columns[2].HeaderText = "Ngày Sinh";
            dgvEmployee.Columns[3].HeaderText = "Giới Tính";
            dgvEmployee.Columns[4].HeaderText = "Địa Chỉ";
            dgvEmployee.Columns[5].HeaderText = "Khoa Học";
            dgvEmployee.Columns[6].HeaderText = "Mã Phòng Ban";
            dgvEmployee.Columns[7].HeaderText = "Ảnh"; // Add header for Birth Date
            dgvEmployee.Columns[8].HeaderText = "Số Điện Thoại";
            dgvEmployee.Columns[9].HeaderText = "Email";
        }

        private void btThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            DangXuat?.Invoke(this, EventArgs.Empty);
        }

        private void Quanly_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (isThoat) Application.Exit();
        }

        private void btAddNew_Click(object sender, EventArgs e)
        {
            try
            {
                int newId = int.Parse(tbId.Text);
                if (lstEmp.Any(emp => emp.Id == newId))
                {
                    MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                    return;
                }
                if (string.IsNullOrEmpty(employeeImagePath))
                {
                    MessageBox.Show("Lỗi: Vui lòng chọn một ảnh.");
                    return;
                }

                // Nếu đường dẫn ảnh không rỗng, hãy hiển thị ảnh
                try
                {
                    Image employeeImage = Image.FromFile(employeeImagePath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi hiển thị ảnh: {ex.Message}");
                }


                if (string.IsNullOrWhiteSpace(tbName.Text))
                {
                    MessageBox.Show("Lỗi: Vui lòng nhập tên hợp lệ.");
                    return;
                }


                Employee newEmp = new Employee
                {
                    Id = newId,
                    Name = tbName.Text,
                    Gender = ckGender.Checked,
                    Address = tbAddress.Text,
                    MaLopHoc = tbMaLopHoc.Text,
                    KhoaHoc = cbKhoaHoc.Text,
                    ImagePath = employeeImagePath,
                    BirthDate = dateTimePicker1.Value.Date,
                    Phone = tbPhone.Text,
                    Email = tbEmail.Text
                };

                lstEmp.Add(newEmp);
                bs.ResetBindings(false);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message);
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            Employee em = lstEmp[idx];

            try
            {
                em.Id = int.Parse(tbId.Text);
                em.Name = tbName.Text;
                em.Gender = ckGender.Checked;
                em.Address = tbAddress.Text;
                em.MaLopHoc = tbMaLopHoc.Text;
                em.KhoaHoc = cbKhoaHoc.Text;
                em.ImagePath = employeeImagePath; // Save the image path
                em.BirthDate = dateTimePicker1.Value.Date; // Update the BirthDate from DateTimePicker
                em.Phone = tbPhone.Text;
                em.Email = tbEmail.Text;
                bs.ResetBindings(false);
                ClearInputFields();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lỗi: Vui lòng nhập số nguyên hợp lệ cho ID.");
            }
        }

        private void btDelete_Click(object sender, EventArgs e)
        {
            if (dgvEmployee.CurrentRow == null) return;

            int idx = dgvEmployee.CurrentRow.Index;
            lstEmp.RemoveAt(idx);
            bs.ResetBindings(false);
        }

        private void dgvEmployee_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= lstEmp.Count) return;

            Employee em = lstEmp[e.RowIndex];

            tbId.Text = em.Id.ToString();
            tbName.Text = em.Name;
            ckGender.Checked = em.Gender;
            tbAddress.Text = em.Address;
            tbMaLopHoc.Text = em.MaLopHoc;
            cbKhoaHoc.Text = em.KhoaHoc;
            tbEmail.Text = em.Email;
            tbPhone.Text = em.Phone;
            dateTimePicker1.Value = em.BirthDate; // Display BirthDate in DateTimePicker

            // Load employee image if exists
            if (!string.IsNullOrEmpty(em.ImagePath) && System.IO.File.Exists(em.ImagePath))
            {
                pbEmployeeImage.Image = Image.FromFile(em.ImagePath);
            }
            else
            {
                pbEmployeeImage.Image = null; // Clear image if not available
            }
        }

        private void ClearInputFields()
        {
            tbId.Text = "";
            tbName.Text = "";
            tbAddress.Text = "";
            tbMaLopHoc.Text = "";
            cbKhoaHoc.Text = "";
            tbPhone.Text = "";
            tbEmail.Text = "";
            ckGender.Checked = false;
            pbEmployeeImage.Image = null; // Clear image display
            dateTimePicker1.Value = DateTime.Now; // Reset DateTimePicker to current date
        }

        private void SetupImageList()
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(24, 24);

            // Add images to ImageList (make sure paths are correct)
            imageList.Images.Add(Image.FromFile("Images/add.png"));    // Index 0
            imageList.Images.Add(Image.FromFile("Images/edit.png"));   // Index 1
            imageList.Images.Add(Image.FromFile("Images/delete.png")); // Index 2

            // Assign ImageList to buttons
            btAddNew.ImageList = imageList;
            btAddNew.ImageIndex = 0;

            btEdit.ImageList = imageList;
            btEdit.ImageIndex = 1;

            btDelete.ImageList = imageList;
            btDelete.ImageIndex = 2;
        }

        private void btSelectImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files (*.jpg;*.jpeg;*.png)|*.jpg;*.jpeg;*.png";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    employeeImagePath = ofd.FileName; // Store the image path
                    pbEmployeeImage.Image = Image.FromFile(employeeImagePath); // Show the image
                }
            }
        }

        // Method to set a specific date for the DateTimePicker (if needed)
        private void SetDateForDateTimePicker(DateTime date)
        {
            dateTimePicker1.Value = date; // Set a specific date, e.g. new DateTime(2024, 10, 17)
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTimePicker1.Value;
            // Do something with the selected date
            this.Text = dateTimePicker1.Value.ToString("dd MMMM yyyy");
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cbMaphongban_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tbId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void tbMaduan_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {
            string newName = tbName.Text; // Get the current text from the textbox

            if (lstEmp.Any(emp => emp.Name == newName))
            {
                MessageBox.Show("Lỗi: ID đã tồn tại. Vui lòng nhập ID khác.");
                return;
            }
        }
    }
}
