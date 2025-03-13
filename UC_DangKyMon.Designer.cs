namespace BTLWinform
{
    partial class UC_DangKyMon
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
            dgvLopTinChi = new DataGridView();
            btnDangKy = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLopTinChi).BeginInit();
            SuspendLayout();
            // 
            // dgvLopTinChi
            // 
            dgvLopTinChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLopTinChi.BackgroundColor = Color.White;
            dgvLopTinChi.ColumnHeadersHeight = 29;
            dgvLopTinChi.Dock = DockStyle.Fill;
            dgvLopTinChi.Location = new Point(0, 0);
            dgvLopTinChi.Name = "dgvLopTinChi";
            dgvLopTinChi.RowHeadersVisible = false;
            dgvLopTinChi.RowHeadersWidth = 51;
            dgvLopTinChi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLopTinChi.Size = new Size(457, 219);
            dgvLopTinChi.TabIndex = 0;
            // 
            // btnDangKy
            // 
            btnDangKy.Dock = DockStyle.Bottom;
            btnDangKy.Location = new Point(0, 219);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(457, 45);
            btnDangKy.TabIndex = 1;
            btnDangKy.Text = "Đăng ký";
            // 
            // UC_DangKyMon
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dgvLopTinChi);
            Controls.Add(btnDangKy);
            Name = "UC_DangKyMon";
            Size = new Size(457, 264);
            ((System.ComponentModel.ISupportInitialize)dgvLopTinChi).EndInit();
            ResumeLayout(false);
        }

        private DataGridView dgvLopTinChi;
        private Button btnDangKy;

        #endregion
    }
}
