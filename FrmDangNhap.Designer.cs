namespace BTLWinform
{
    partial class FrmDangNhap
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTaiKhoan = new TextBox();
            txtMatKhau = new TextBox();
            btnDangNhap = new Button();
            groupBox1 = new GroupBox();
            rdoGiangVien = new RadioButton();
            rdoSinhVien = new RadioButton();
            label4 = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(167, 22);
            label1.Name = "label1";
            label1.Size = new Size(174, 33);
            label1.TabIndex = 0;
            label1.Text = "ĐĂNG NHẬP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 86);
            label2.Name = "label2";
            label2.Size = new Size(130, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 177);
            label3.Name = "label3";
            label3.Size = new Size(88, 22);
            label3.TabIndex = 2;
            label3.Text = "Mật khẩu:";
            // 
            // txtTaiKhoan
            // 
            txtTaiKhoan.Location = new Point(65, 126);
            txtTaiKhoan.Name = "txtTaiKhoan";
            txtTaiKhoan.Size = new Size(371, 30);
            txtTaiKhoan.TabIndex = 3;
            // 
            // txtMatKhau
            // 
            txtMatKhau.Location = new Point(65, 214);
            txtMatKhau.Name = "txtMatKhau";
            txtMatKhau.PasswordChar = '*';
            txtMatKhau.Size = new Size(371, 30);
            txtMatKhau.TabIndex = 4;
            // 
            // btnDangNhap
            // 
            btnDangNhap.Location = new Point(167, 324);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(162, 38);
            btnDangNhap.TabIndex = 5;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = true;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rdoGiangVien);
            groupBox1.Controls.Add(rdoSinhVien);
            groupBox1.Location = new Point(143, 250);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(293, 51);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            // 
            // rdoGiangVien
            // 
            rdoGiangVien.AutoSize = true;
            rdoGiangVien.Location = new Point(130, 20);
            rdoGiangVien.Name = "rdoGiangVien";
            rdoGiangVien.Size = new Size(117, 26);
            rdoGiangVien.TabIndex = 11;
            rdoGiangVien.Text = "Giảng viên";
            rdoGiangVien.UseVisualStyleBackColor = true;
            // 
            // rdoSinhVien
            // 
            rdoSinhVien.AutoSize = true;
            rdoSinhVien.Checked = true;
            rdoSinhVien.Location = new Point(6, 20);
            rdoSinhVien.Name = "rdoSinhVien";
            rdoSinhVien.Size = new Size(105, 26);
            rdoSinhVien.TabIndex = 10;
            rdoSinhVien.TabStop = true;
            rdoSinhVien.Text = "Sinh viên";
            rdoSinhVien.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(65, 270);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 9;
            label4.Text = "Bạn là:";
            // 
            // FrmDangNhap
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(519, 411);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(btnDangNhap);
            Controls.Add(txtMatKhau);
            Controls.Add(txtTaiKhoan);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "FrmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmDangNhap";
            Load += FrmDangNhap_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTaiKhoan;
        private TextBox txtMatKhau;
        private Button btnDangNhap;
        private GroupBox groupBox1;
        private Label label4;
        private RadioButton rdoGiangVien;
        private RadioButton rdoSinhVien;
    }
}