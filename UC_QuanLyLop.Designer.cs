namespace BTLWinform
{
    partial class UC_QuanLyLop
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
            cboMonHoc = new ComboBox();
            label2 = new Label();
            cboGiangVien = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            dateBatDau = new DateTimePicker();
            dateKetThuc = new DateTimePicker();
            label5 = new Label();
            clLichHoc = new CheckedListBox();
            label6 = new Label();
            btnLamMoi = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThem = new Button();
            dataGridView1 = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            SubjectId = new DataGridViewTextBoxColumn();
            TeacherId = new DataGridViewTextBoxColumn();
            Schedule = new DataGridViewTextBoxColumn();
            StartDate = new DataGridViewTextBoxColumn();
            EndDate = new DataGridViewTextBoxColumn();
            Room = new DataGridViewTextBoxColumn();
            cboPhongHoc = new ComboBox();
            label7 = new Label();
            txtMaLop = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 27);
            label1.Name = "label1";
            label1.Size = new Size(98, 19);
            label1.TabIndex = 0;
            label1.Text = "Chọn môn học";
            // 
            // cboMonHoc
            // 
            cboMonHoc.FormattingEnabled = true;
            cboMonHoc.Location = new Point(238, 24);
            cboMonHoc.Name = "cboMonHoc";
            cboMonHoc.Size = new Size(242, 27);
            cboMonHoc.TabIndex = 1;
            cboMonHoc.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(573, 27);
            label2.Name = "label2";
            label2.Size = new Size(105, 19);
            label2.TabIndex = 2;
            label2.Text = "Chọn giảng viên";
            // 
            // cboGiangVien
            // 
            cboGiangVien.FormattingEnabled = true;
            cboGiangVien.Location = new Point(798, 27);
            cboGiangVien.Name = "cboGiangVien";
            cboGiangVien.Size = new Size(242, 27);
            cboGiangVien.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 155);
            label3.Name = "label3";
            label3.Size = new Size(123, 19);
            label3.TabIndex = 4;
            label3.Text = "Chọn ngày bắt đầu";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(573, 214);
            label4.Name = "label4";
            label4.Size = new Size(126, 19);
            label4.TabIndex = 5;
            label4.Text = "Chọn ngày kết thúc";
            // 
            // dateBatDau
            // 
            dateBatDau.Format = DateTimePickerFormat.Short;
            dateBatDau.Location = new Point(836, 149);
            dateBatDau.Name = "dateBatDau";
            dateBatDau.Size = new Size(140, 26);
            dateBatDau.TabIndex = 31;
            // 
            // dateKetThuc
            // 
            dateKetThuc.Format = DateTimePickerFormat.Short;
            dateKetThuc.Location = new Point(836, 206);
            dateKetThuc.Name = "dateKetThuc";
            dateKetThuc.Size = new Size(140, 26);
            dateKetThuc.TabIndex = 32;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(35, 149);
            label5.Name = "label5";
            label5.Size = new Size(92, 19);
            label5.TabIndex = 33;
            label5.Text = "Chọn lịch học";
            // 
            // clLichHoc
            // 
            clLichHoc.FormattingEnabled = true;
            clLichHoc.Items.AddRange(new object[] { "Sáng thứ 2", "Chiều thứ 2", "Sáng thứ 3", "Chiều thứ 3", "Sáng thứ 4", "Chiều thứ 4", "Sáng thứ 5", "Chiều thứ 5", "Sáng thứ 6", "Chiều thứ 6", "Sáng thứ 7", "Chiều thứ 7" });
            clLichHoc.Location = new Point(238, 82);
            clLichHoc.Name = "clLichHoc";
            clLichHoc.Size = new Size(291, 151);
            clLichHoc.TabIndex = 35;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(573, 91);
            label6.Name = "label6";
            label6.Size = new Size(109, 19);
            label6.TabIndex = 36;
            label6.Text = "Chọn phòng học";
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(933, 290);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(147, 45);
            btnLamMoi.TabIndex = 42;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(798, 291);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(94, 45);
            btnXoa.TabIndex = 41;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(661, 291);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(94, 43);
            btnSua.TabIndex = 40;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(525, 291);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(94, 42);
            btnThem.TabIndex = 39;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { ID, SubjectId, TeacherId, Schedule, StartDate, EndDate, Room });
            dataGridView1.Location = new Point(0, 363);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1110, 274);
            dataGridView1.TabIndex = 43;
            dataGridView1.TabStop = false;
            dataGridView1.CellClick += dataGridView1_CellClick;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // ID
            // 
            ID.FillWeight = 54.1103F;
            ID.HeaderText = "ID";
            ID.MinimumWidth = 6;
            ID.Name = "ID";
            ID.ReadOnly = true;
            // 
            // SubjectId
            // 
            SubjectId.HeaderText = "Môn Học";
            SubjectId.MinimumWidth = 10;
            SubjectId.Name = "SubjectId";
            SubjectId.ReadOnly = true;
            // 
            // TeacherId
            // 
            TeacherId.HeaderText = "Giảng Viên";
            TeacherId.MinimumWidth = 10;
            TeacherId.Name = "TeacherId";
            TeacherId.ReadOnly = true;
            // 
            // Schedule
            // 
            Schedule.HeaderText = "Lịch học";
            Schedule.MinimumWidth = 10;
            Schedule.Name = "Schedule";
            Schedule.ReadOnly = true;
            // 
            // StartDate
            // 
            StartDate.HeaderText = "Ngày bắt đầu";
            StartDate.MinimumWidth = 10;
            StartDate.Name = "StartDate";
            StartDate.ReadOnly = true;
            // 
            // EndDate
            // 
            EndDate.HeaderText = "Ngày kết thúc";
            EndDate.MinimumWidth = 10;
            EndDate.Name = "EndDate";
            EndDate.ReadOnly = true;
            // 
            // Room
            // 
            Room.HeaderText = "Phòng học";
            Room.MinimumWidth = 10;
            Room.Name = "Room";
            Room.ReadOnly = true;
            // 
            // cboPhongHoc
            // 
            cboPhongHoc.FormattingEnabled = true;
            cboPhongHoc.Location = new Point(799, 83);
            cboPhongHoc.Name = "cboPhongHoc";
            cboPhongHoc.Size = new Size(162, 27);
            cboPhongHoc.TabIndex = 44;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(35, 290);
            label7.Name = "label7";
            label7.Size = new Size(113, 19);
            label7.TabIndex = 45;
            label7.Text = "Chọn mã lớp học";
            // 
            // txtMaLop
            // 
            txtMaLop.Location = new Point(271, 282);
            txtMaLop.Name = "txtMaLop";
            txtMaLop.Size = new Size(200, 26);
            txtMaLop.TabIndex = 46;
            // 
            // UC_QuanLyLop
            // 
            AutoScaleMode = AutoScaleMode.None;
            AutoSize = true;
            Controls.Add(txtMaLop);
            Controls.Add(label7);
            Controls.Add(cboPhongHoc);
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(label6);
            Controls.Add(clLichHoc);
            Controls.Add(label5);
            Controls.Add(dateKetThuc);
            Controls.Add(dateBatDau);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cboGiangVien);
            Controls.Add(label2);
            Controls.Add(cboMonHoc);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "UC_QuanLyLop";
            Size = new Size(1113, 640);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboMonHoc;
        private Label label2;
        private ComboBox cboGiangVien;
        private Label label3;
        private Label label4;
        private DateTimePicker dateBatDau;
        private DateTimePicker dateKetThuc;
        private Label label5;
        private CheckedListBox clLichHoc;
        private Label label6;
        private Button btnLamMoi;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThem;
        private DataGridView dataGridView1;
        private ComboBox cboPhongHoc;
        private Label label7;
        private TextBox txtMaLop;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn SubjectId;
        private DataGridViewTextBoxColumn TeacherId;
        private DataGridViewTextBoxColumn Schedule;
        private DataGridViewTextBoxColumn StartDate;
        private DataGridViewTextBoxColumn EndDate;
        private DataGridViewTextBoxColumn Room;
    }
}
