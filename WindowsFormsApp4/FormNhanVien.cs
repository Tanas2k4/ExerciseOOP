using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class FormNhanVien : Form
    {


        public delegate void SendDataDelegate(string msnv, string tenNV, decimal luongCB);
        public event SendDataDelegate DataSent;
        public FormNhanVien()
        {
            InitializeComponent();
        }

        public FormNhanVien(string msnv, string tenNV, decimal luongCB) : this()
        {
            txtMSNV.Text = msnv;
            txtTenNV.Text = tenNV;
            txtLuong.Text = luongCB.ToString();
        }

        //Hàm clear
        private void ClearTextBoxes()
        {
            txtMSNV.Clear();
            txtTenNV.Clear();
            txtLuong.Clear();
        }
        //Nút Button đồng ý
        private void btn_DongY_Click(object sender, EventArgs e)
        {
            string msnv = txtMSNV.Text;
            string tenNV = txtTenNV.Text;
            decimal luongCB = decimal.Parse(txtLuong.Text);
            DataSent?.Invoke(msnv, tenNV, luongCB);
            MessageBox.Show("Thêm thành công!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            ClearTextBoxes();  
        }

        // Button thoát
        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
