namespace BTLWinform
{
    partial class UC_QuanLySinhVien
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
            txtID = new TextBox();
            txtMaSV = new TextBox();
            txtTenSV = new TextBox();
            txtNgaySinh = new DateTimePicker();
            label8 = new Label();
            rdNu = new RadioButton();
            rdNam = new RadioButton();
            txtSDT = new TextBox();
            txtDiaChi = new TextBox();
            txtEmail = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 35);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(208, 35);
            label2.Name = "label2";
            label2.Size = new Size(56, 19);
            label2.TabIndex = 0;
            label2.Text = "Mã SV:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(559, 35);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 0;
            label3.Text = "Tên SV:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(58, 92);
            label4.Name = "label4";
            label4.Size = new Size(72, 19);
            label4.TabIndex = 0;
            label4.Text = "Ngày sinh:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 147);
            label5.Name = "label5";
            label5.Size = new Size(54, 19);
            label5.TabIndex = 0;
            label5.Text = "Địa chỉ:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 203);
            label6.Name = "label6";
            label6.Size = new Size(45, 19);
            label6.TabIndex = 0;
            label6.Text = "Email:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(571, 92);
            label7.Name = "label7";
            label7.Size = new Size(40, 19);
            label7.TabIndex = 0;
            label7.Text = "SĐT:";
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(100, 32);
            txtID.Name = "txtID";
            txtID.Size = new Size(78, 26);
            txtID.TabIndex = 1;
            // 
            // txtMaSV
            // 
            txtMaSV.Location = new Point(284, 32);
            txtMaSV.Name = "txtMaSV";
            txtMaSV.Size = new Size(243, 26);
            txtMaSV.TabIndex = 2;
            // 
            // txtTenSV
            // 
            txtTenSV.Location = new Point(639, 32);
            txtTenSV.Name = "txtTenSV";
            txtTenSV.Size = new Size(243, 26);
            txtTenSV.TabIndex = 3;
            // 
            // txtNgaySinh
            // 
            txtNgaySinh.Format = DateTimePickerFormat.Short;
            txtNgaySinh.Location = new Point(158, 86);
            txtNgaySinh.Name = "txtNgaySinh";
            txtNgaySinh.Size = new Size(140, 26);
            txtNgaySinh.TabIndex = 4;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(324, 92);
            label8.Name = "label8";
            label8.Size = new Size(62, 19);
            label8.TabIndex = 0;
            label8.Text = "Giới tính:";
            // 
            // rdNu
            // 
            rdNu.AutoSize = true;
            rdNu.Location = new Point(491, 90);
            rdNu.Name = "rdNu";
            rdNu.Size = new Size(48, 23);
            rdNu.TabIndex = 13;
            rdNu.TabStop = true;
            rdNu.Text = "Nữ";
            rdNu.UseVisualStyleBackColor = true;
            // 
            // rdNam
            // 
            rdNam.AutoSize = true;
            rdNam.Location = new Point(417, 90);
            rdNam.Name = "rdNam";
            rdNam.Size = new Size(57, 23);
            rdNam.TabIndex = 12;
            rdNam.TabStop = true;
            rdNam.Text = "Nam";
            rdNam.UseVisualStyleBackColor = true;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(629, 86);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(243, 26);
            txtSDT.TabIndex = 2;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(138, 144);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(328, 26);
            txtDiaChi.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(138, 200);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(328, 26);
            txtEmail.TabIndex = 15;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(559, 144);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 29);
            btnThem.TabIndex = 16;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(706, 144);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 29);
            btnSua.TabIndex = 16;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(559, 203);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 29);
            btnXoa.TabIndex = 16;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(706, 203);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(94, 29);
            btnLamMoi.TabIndex = 16;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += button4_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8 });
            dataGridView1.Location = new Point(0, 254);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(970, 364);
            dataGridView1.TabIndex = 17;
            dataGridView1.TabStop = false;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.FillWeight = 54.1103F;
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.FillWeight = 122.503128F;
            Column2.HeaderText = "Mã SV";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.FillWeight = 118.497437F;
            Column3.HeaderText = "Tên SV";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.FillWeight = 102.745789F;
            Column4.HeaderText = "Ngày sinh";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // Column5
            // 
            Column5.FillWeight = 101.739166F;
            Column5.HeaderText = "Giới tính";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            // 
            // Column6
            // 
            Column6.FillWeight = 100.86348F;
            Column6.HeaderText = "SĐT";
            Column6.MinimumWidth = 6;
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            // 
            // Column7
            // 
            Column7.FillWeight = 100.101677F;
            Column7.HeaderText = "Địa chỉ";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            // 
            // Column8
            // 
            Column8.FillWeight = 99.4389648F;
            Column8.HeaderText = "Email";
            Column8.MinimumWidth = 6;
            Column8.Name = "Column8";
            Column8.ReadOnly = true;
            // 
            // UC_QuanLySinhVien
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtEmail);
            Controls.Add(txtDiaChi);
            Controls.Add(rdNu);
            Controls.Add(rdNam);
            Controls.Add(txtNgaySinh);
            Controls.Add(txtTenSV);
            Controls.Add(txtSDT);
            Controls.Add(txtMaSV);
            Controls.Add(txtID);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_QuanLySinhVien";
            Size = new Size(970, 618);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
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
        private TextBox txtID;
        private TextBox txtMaSV;
        private TextBox txtTenSV;
        private DateTimePicker txtNgaySinh;
        private Label label8;
        private RadioButton rdNu;
        private RadioButton rdNam;
        private TextBox txtSDT;
        private TextBox txtDiaChi;
        private TextBox txtEmail;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
    }
}
