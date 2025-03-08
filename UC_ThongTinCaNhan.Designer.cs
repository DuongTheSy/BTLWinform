namespace BTLWinform
{
    partial class UC_ThongTinCaNhan
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtMa = new TextBox();
            txtTen = new TextBox();
            dNgaySinh = new DateTimePicker();
            rdNam = new RadioButton();
            rdNu = new RadioButton();
            txtEmail = new TextBox();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 28);
            label1.Name = "label1";
            label1.Size = new Size(118, 22);
            label1.TabIndex = 0;
            label1.Text = "Mã sinh viên:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 76);
            label2.Name = "label2";
            label2.Size = new Size(122, 22);
            label2.TabIndex = 1;
            label2.Text = "Tên sinh viên:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 131);
            label3.Name = "label3";
            label3.Size = new Size(94, 22);
            label3.TabIndex = 2;
            label3.Text = "Ngày sinh:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 183);
            label4.Name = "label4";
            label4.Size = new Size(87, 22);
            label4.TabIndex = 3;
            label4.Text = "Giới tính:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(50, 226);
            label5.Name = "label5";
            label5.Size = new Size(63, 22);
            label5.TabIndex = 4;
            label5.Text = "Email:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 273);
            label6.Name = "label6";
            label6.Size = new Size(120, 22);
            label6.TabIndex = 5;
            label6.Text = "Số điện thoại:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 321);
            label7.Name = "label7";
            label7.Size = new Size(74, 22);
            label7.TabIndex = 6;
            label7.Text = "Địa chỉ:";
            // 
            // txtMa
            // 
            txtMa.Enabled = false;
            txtMa.Location = new Point(176, 25);
            txtMa.Name = "txtMa";
            txtMa.Size = new Size(320, 30);
            txtMa.TabIndex = 7;
            // 
            // txtTen
            // 
            txtTen.Enabled = false;
            txtTen.Location = new Point(176, 73);
            txtTen.Name = "txtTen";
            txtTen.Size = new Size(320, 30);
            txtTen.TabIndex = 8;
            // 
            // dNgaySinh
            // 
            dNgaySinh.Enabled = false;
            dNgaySinh.Format = DateTimePickerFormat.Short;
            dNgaySinh.Location = new Point(176, 123);
            dNgaySinh.Name = "dNgaySinh";
            dNgaySinh.Size = new Size(143, 30);
            dNgaySinh.TabIndex = 9;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Enabled = false;
            rdNam.Location = new Point(176, 183);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(68, 26);
            rdNam.TabIndex = 10;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Enabled = false;
            rdNu.Location = new Point(288, 181);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(56, 26);
            rdNu.TabIndex = 11;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            txtEmail.Enabled = false;
            txtEmail.Location = new Point(176, 223);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(320, 30);
            txtEmail.TabIndex = 12;
            // 
            // txtSDT
            // 
            txtSDT.Enabled = false;
            txtSDT.Location = new Point(176, 270);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(320, 30);
            txtSDT.TabIndex = 13;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Enabled = false;
            txtDiaChi.Location = new Point(176, 318);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(320, 30);
            txtDiaChi.TabIndex = 14;
            // 
            // UC_ThongTinCaNhan
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(txtDiaChi);
            Controls.Add(txtSDT);
            Controls.Add(txtEmail);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(dNgaySinh);
            Controls.Add(txtTen);
            Controls.Add(txtMa);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_ThongTinCaNhan";
            Size = new Size(970, 618);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtMa;
        private TextBox txtTen;
        private DateTimePicker dNgaySinh;
        private RadioButton rdNam;
        private RadioButton rdNu;
        private TextBox txtEmail;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
    }
}
