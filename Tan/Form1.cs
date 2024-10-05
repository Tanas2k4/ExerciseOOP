using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tan.Models;

namespace Tan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData(); // Tải dữ liệu ban đầu
            LoadKhoaToComboBox(); // Nạp khoa vào ComboBox
        }
        private void LoadData()
        {
            try
            {
                using (Models.Model1 context = new Models.Model1())
                {
                    var studentsList = (from student in context.Students
                                        join faculty in context.Faculties
                                        on student.FacultyID equals faculty.FacultyID
                                        select new
                                        {
                                            Mã_số_SV = student.StudentID,
                                            Họ_tên = student.FullName,
                                            Tên_khoa = faculty.FacultyName,
                                            Điểm_TB = student.GPA
                                        }).ToList();

                    dataGridView1.DataSource = studentsList;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        // Hàm nạp dữ liệu vào ComboBox Khoa
        private void LoadKhoaToComboBox()
        {
            try
            {
                using (Models.Model1 context = new Models.Model1())
                {
                    var faculties = context.Faculties.ToList();
                    cmbKhoa.DataSource = faculties;
                    cmbKhoa.DisplayMember = "FacultyName";  // Hiển thị tên khoa
                    cmbKhoa.ValueMember = "FacultyID";      // Lưu mã khoa vào value
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void txtMSSV_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtHoTen_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbKhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDiemTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                using (Models.Model1 context = new Models.Model1())
                {
                    // Tạo đối tượng Student mới từ dữ liệu nhập vào
                    Student newStudent = new Student
                    {
                        StudentID = int.Parse(txtMSSV.Text),
                        FullName = txtHoTen.Text,
                        FacultyID = (int)cmbKhoa.SelectedValue, // Lấy mã khoa từ ComboBox
                        GPA = float.Parse(txtDiemTB.Text)
                    };

                    // Thêm sinh viên mới vào context
                    context.Students.Add(newStudent);
                    context.SaveChanges(); // Lưu vào cơ sở dữ liệu

                    // Cập nhật lại DataGridView
                    LoadData();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                using (Models.Model1 context = new Models.Model1())
                {
                    int studentID = int.Parse(txtMSSV.Text);
                    // Tìm sinh viên cần xóa
                    var student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                    if (student != null)
                    {
                        // Xóa sinh viên khỏi database
                        context.Students.Remove(student);
                        context.SaveChanges(); // Lưu thay đổi

                        // Cập nhật lại DataGridView
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần xóa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            try
            {
                using (Models.Model1 context = new Models.Model1())
                {
                    int studentID = int.Parse(txtMSSV.Text);
                    // Tìm sinh viên cần sửa
                    var student = context.Students.FirstOrDefault(s => s.StudentID == studentID);

                    if (student != null)
                    {
                        // Cập nhật thông tin sinh viên
                        student.FullName = txtHoTen.Text;
                        student.FacultyID = (int)cmbKhoa.SelectedValue;
                        student.GPA = float.Parse(txtDiemTB.Text);

                        context.SaveChanges(); // Lưu thay đổi

                        // Cập nhật lại DataGridView
                        LoadData();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy sinh viên cần sửa.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Kiểm tra xem có chọn đúng hàng không
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                // Gán giá trị từ hàng đã chọn vào các TextBox và ComboBox
                txtMSSV.Text = row.Cells["Mã_số_SV"].Value.ToString();
                txtHoTen.Text = row.Cells["Họ_tên"].Value.ToString();
                cmbKhoa.Text = row.Cells["Tên_khoa"].Value.ToString();
                txtDiemTB.Text = row.Cells["Điểm_TB"].Value.ToString();
            }
        }
       
    }
}
