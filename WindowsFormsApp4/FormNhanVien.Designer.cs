namespace WindowsFormsApp4
{
    partial class FormNhanVien
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
            this.lbl_MSNV = new System.Windows.Forms.Label();
            this.lol_TenNV = new System.Windows.Forms.Label();
            this.lbl_Luong = new System.Windows.Forms.Label();
            this.txtMSNV = new System.Windows.Forms.TextBox();
            this.txtLuong = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.btn_DongY = new System.Windows.Forms.Button();
            this.btn_Thoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_MSNV
            // 
            this.lbl_MSNV.AutoSize = true;
            this.lbl_MSNV.Location = new System.Drawing.Point(37, 28);
            this.lbl_MSNV.Name = "lbl_MSNV";
            this.lbl_MSNV.Size = new System.Drawing.Size(86, 16);
            this.lbl_MSNV.TabIndex = 5;
            this.lbl_MSNV.Text = "Mã nhân viên";
            // 
            // lol_TenNV
            // 
            this.lol_TenNV.AutoSize = true;
            this.lol_TenNV.Location = new System.Drawing.Point(37, 68);
            this.lol_TenNV.Name = "lol_TenNV";
            this.lol_TenNV.Size = new System.Drawing.Size(52, 16);
            this.lol_TenNV.TabIndex = 6;
            this.lol_TenNV.Text = "Họ Tên";
            // 
            // lbl_Luong
            // 
            this.lbl_Luong.AutoSize = true;
            this.lbl_Luong.Location = new System.Drawing.Point(37, 111);
            this.lbl_Luong.Name = "lbl_Luong";
            this.lbl_Luong.Size = new System.Drawing.Size(65, 16);
            this.lbl_Luong.TabIndex = 7;
            this.lbl_Luong.Text = "Lương CB";
            // 
            // txtMSNV
            // 
            this.txtMSNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMSNV.Location = new System.Drawing.Point(136, 25);
            this.txtMSNV.Multiline = true;
            this.txtMSNV.Name = "txtMSNV";
            this.txtMSNV.Size = new System.Drawing.Size(174, 25);
            this.txtMSNV.TabIndex = 0;
            // 
            // txtLuong
            // 
            this.txtLuong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLuong.Location = new System.Drawing.Point(136, 102);
            this.txtLuong.Multiline = true;
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.Size = new System.Drawing.Size(174, 25);
            this.txtLuong.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(145, 65);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 25);
            this.textBox3.TabIndex = 1;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTenNV.Location = new System.Drawing.Point(136, 65);
            this.txtTenNV.Multiline = true;
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(264, 25);
            this.txtTenNV.TabIndex = 1;
            // 
            // btn_DongY
            // 
            this.btn_DongY.Location = new System.Drawing.Point(65, 150);
            this.btn_DongY.Name = "btn_DongY";
            this.btn_DongY.Size = new System.Drawing.Size(97, 40);
            this.btn_DongY.TabIndex = 3;
            this.btn_DongY.Text = "Đồng ý ";
            this.btn_DongY.UseVisualStyleBackColor = true;
            this.btn_DongY.Click += new System.EventHandler(this.btn_DongY_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.Location = new System.Drawing.Point(243, 150);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(97, 40);
            this.btn_Thoat.TabIndex = 4;
            this.btn_Thoat.Text = "Bỏ qua";
            this.btn_Thoat.UseVisualStyleBackColor = true;
            this.btn_Thoat.Click += new System.EventHandler(this.btn_Thoat_Click);
            // 
            // FormNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 223);
            this.Controls.Add(this.btn_Thoat);
            this.Controls.Add(this.btn_DongY);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.txtMSNV);
            this.Controls.Add(this.lbl_Luong);
            this.Controls.Add(this.lol_TenNV);
            this.Controls.Add(this.lbl_MSNV);
            this.Name = "FormNhanVien";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_MSNV;
        private System.Windows.Forms.Label lol_TenNV;
        private System.Windows.Forms.Label lbl_Luong;
        private System.Windows.Forms.TextBox txtMSNV;
        private System.Windows.Forms.TextBox txtLuong;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btn_DongY;
        private System.Windows.Forms.Button btn_Thoat;
    }
}

