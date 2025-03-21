namespace BTLWinform
{
    partial class UC_QuanLyMonHoc
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
            txtID = new TextBox();
            txtMonHoc = new TextBox();
            txtMaMonHoc = new TextBox();
            txtSoTinChi = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnLamMoi = new Button();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 42);
            label1.Name = "label1";
            label1.Size = new Size(28, 19);
            label1.TabIndex = 0;
            label1.Text = "ID:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 42);
            label2.Name = "label2";
            label2.Size = new Size(91, 19);
            label2.TabIndex = 0;
            label2.Text = "Tên môn học:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(211, 103);
            label3.Name = "label3";
            label3.Size = new Size(89, 19);
            label3.TabIndex = 0;
            label3.Text = "Mã môn học:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(563, 104);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 0;
            label4.Text = "Số tín chỉ:";
            // 
            // txtID
            // 
            txtID.Location = new Point(253, 39);
            txtID.Name = "txtID";
            txtID.Size = new Size(83, 26);
            txtID.TabIndex = 1;
            // 
            // txtMonHoc
            // 
            txtMonHoc.Location = new Point(509, 39);
            txtMonHoc.Name = "txtMonHoc";
            txtMonHoc.Size = new Size(228, 26);
            txtMonHoc.TabIndex = 2;
            // 
            // txtMaMonHoc
            // 
            txtMaMonHoc.Location = new Point(330, 99);
            txtMaMonHoc.Name = "txtMaMonHoc";
            txtMaMonHoc.Size = new Size(188, 26);
            txtMaMonHoc.TabIndex = 3;
            // 
            // txtSoTinChi
            // 
            txtSoTinChi.Location = new Point(660, 99);
            txtSoTinChi.Name = "txtSoTinChi";
            txtSoTinChi.Size = new Size(89, 26);
            txtSoTinChi.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(747, 216);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(91, 29);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(864, 216);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(91, 29);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(747, 281);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(91, 29);
            btnXoa.TabIndex = 5;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnLamMoi
            // 
            btnLamMoi.Location = new Point(864, 281);
            btnLamMoi.Name = "btnLamMoi";
            btnLamMoi.Size = new Size(91, 29);
            btnLamMoi.TabIndex = 5;
            btnLamMoi.Text = "Làm mới";
            btnLamMoi.UseVisualStyleBackColor = true;
            btnLamMoi.Click += btnLamMoi_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dataGridView1.Location = new Point(0, 200);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(723, 415);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellClick += dataGridView1_CellClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Mã môn học";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tên môn học";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Số tín chỉ";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // UC_QuanLyMonHoc
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(btnLamMoi);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSoTinChi);
            Controls.Add(txtMaMonHoc);
            Controls.Add(txtMonHoc);
            Controls.Add(txtID);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "UC_QuanLyMonHoc";
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
        private TextBox txtID;
        private TextBox txtMonHoc;
        private TextBox txtMaMonHoc;
        private TextBox txtSoTinChi;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private Button btnLamMoi;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
    }
}
