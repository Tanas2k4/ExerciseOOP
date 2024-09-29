using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_them_Click(object sender, EventArgs e)
        {
            FormNhanVien formNhanVien = new FormNhanVien();
            formNhanVien.DataSent += new FormNhanVien.SendDataDelegate(AddDataToGridView);
            formNhanVien.Show();
        }
        

        private void btn_sua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                string msnv = selectedRow.Cells[0].Value.ToString();
                string tenNV = selectedRow.Cells[1].Value.ToString();
                decimal luongCB = Convert.ToDecimal(selectedRow.Cells[2].Value);

                FormNhanVien formNhanVien = new FormNhanVien(msnv, tenNV, luongCB);
                formNhanVien.DataSent += new FormNhanVien.SendDataDelegate(UpdateDataInGridView);
                formNhanVien.Show();
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để sửa.");
            }
        }
        private void AddDataToGridView(string msnv, string tenNV, decimal luongCB)
        {
            dataGridView1.Rows.Add(msnv, tenNV, luongCB);
        }
        private void UpdateDataInGridView(string msnv, string tenNV, decimal luongCB)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                selectedRow.Cells[0].Value = msnv;
                selectedRow.Cells[1].Value = tenNV;
                selectedRow.Cells[2].Value = luongCB;
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một hàng để xóa.");
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true; // Hủy việc đóng form nếu người dùng chọn "Cancel"
            }
        }
    }
}
