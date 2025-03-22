namespace BTLWinform
{
    partial class FrmAdmin
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
            panelMenu = new Panel();
            btnQuanLyLopTinChi = new Button();
            btnQuanLyMonHoc = new Button();
            btnQuanLyGiangVien = new Button();
            btnQuanLySinhVien = new Button();
            btnTrangchu = new Button();
            btnDangXuat = new Button();
            panelContent = new Panel();
            pnContent = new Panel();
            lblTitle = new Label();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(41, 128, 185);
            panelMenu.Controls.Add(btnQuanLyLopTinChi);
            panelMenu.Controls.Add(btnQuanLyMonHoc);
            panelMenu.Controls.Add(btnQuanLyGiangVien);
            panelMenu.Controls.Add(btnQuanLySinhVien);
            panelMenu.Controls.Add(btnTrangchu);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 688);
            panelMenu.TabIndex = 1;
            // 
            // btnQuanLyLopTinChi
            // 
            btnQuanLyLopTinChi.Dock = DockStyle.Top;
            btnQuanLyLopTinChi.FlatStyle = FlatStyle.Flat;
            btnQuanLyLopTinChi.ForeColor = Color.White;
            btnQuanLyLopTinChi.Location = new Point(0, 200);
            btnQuanLyLopTinChi.Name = "btnQuanLyLopTinChi";
            btnQuanLyLopTinChi.Size = new Size(220, 50);
            btnQuanLyLopTinChi.TabIndex = 5;
            btnQuanLyLopTinChi.Text = "Quản lý lớp tín chỉ";
            btnQuanLyLopTinChi.UseVisualStyleBackColor = true;
            btnQuanLyLopTinChi.Click += btnQuanLyLopTinChi_Click;
            // 
            // btnQuanLyMonHoc
            // 
            btnQuanLyMonHoc.Dock = DockStyle.Top;
            btnQuanLyMonHoc.FlatStyle = FlatStyle.Flat;
            btnQuanLyMonHoc.ForeColor = Color.White;
            btnQuanLyMonHoc.Location = new Point(0, 150);
            btnQuanLyMonHoc.Name = "btnQuanLyMonHoc";
            btnQuanLyMonHoc.Size = new Size(220, 50);
            btnQuanLyMonHoc.TabIndex = 2;
            btnQuanLyMonHoc.Text = "Quản lý môn học";
            btnQuanLyMonHoc.UseVisualStyleBackColor = true;
            btnQuanLyMonHoc.Click += btnQuanLyMonHoc_Click;
            // 
            // btnQuanLyGiangVien
            // 
            btnQuanLyGiangVien.Dock = DockStyle.Top;
            btnQuanLyGiangVien.FlatStyle = FlatStyle.Flat;
            btnQuanLyGiangVien.ForeColor = Color.White;
            btnQuanLyGiangVien.Location = new Point(0, 100);
            btnQuanLyGiangVien.Name = "btnQuanLyGiangVien";
            btnQuanLyGiangVien.Size = new Size(220, 50);
            btnQuanLyGiangVien.TabIndex = 0;
            btnQuanLyGiangVien.Text = "Quản lý giảng viên";
            btnQuanLyGiangVien.Click += btnQuanLyGiangVien_Click;
            // 
            // btnQuanLySinhVien
            // 
            btnQuanLySinhVien.Dock = DockStyle.Top;
            btnQuanLySinhVien.FlatStyle = FlatStyle.Flat;
            btnQuanLySinhVien.ForeColor = Color.White;
            btnQuanLySinhVien.Location = new Point(0, 50);
            btnQuanLySinhVien.Name = "btnQuanLySinhVien";
            btnQuanLySinhVien.Size = new Size(220, 50);
            btnQuanLySinhVien.TabIndex = 1;
            btnQuanLySinhVien.Text = "Quản lý sinh viên";
            btnQuanLySinhVien.Click += btnQuanLySinhVien_Click;
            // 
            // btnTrangchu
            // 
            btnTrangchu.Dock = DockStyle.Top;
            btnTrangchu.FlatStyle = FlatStyle.Flat;
            btnTrangchu.ForeColor = Color.White;
            btnTrangchu.Location = new Point(0, 0);
            btnTrangchu.Name = "btnTrangchu";
            btnTrangchu.Size = new Size(220, 50);
            btnTrangchu.TabIndex = 2;
            btnTrangchu.Text = "Trang chủ";
            // 
            // btnDangXuat
            // 
            btnDangXuat.Dock = DockStyle.Bottom;
            btnDangXuat.FlatStyle = FlatStyle.Flat;
            btnDangXuat.ForeColor = Color.White;
            btnDangXuat.Location = new Point(0, 638);
            btnDangXuat.Name = "btnDangXuat";
            btnDangXuat.Size = new Size(220, 50);
            btnDangXuat.TabIndex = 3;
            btnDangXuat.Text = "Đăng xuất";
            btnDangXuat.Click += btnDangXuat_Click;
            // 
            // panelContent
            // 
            panelContent.BackColor = Color.White;
            panelContent.Controls.Add(pnContent);
            panelContent.Controls.Add(lblTitle);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(220, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(970, 688);
            panelContent.TabIndex = 0;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(0, 70);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(970, 618);
            pnContent.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(970, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Chúc một ngày tốt lành";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FrmAdmin
            // 
            ClientSize = new Size(1190, 688);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Name = "FrmAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quyền quản trị viên";
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelMenu;
        private Button btnQuanLySinhVien;
        private Button btnTrangchu;
        private Button btnDangXuat;
        private Panel panelContent;
        private Label lblTitle;
        #endregion

        private Button btnQuanLyGiangVien;
        private Panel pnContent;
        private Button btnQuanLyMonHoc;
        private Button btnQuanLyLopTinChi;
    }
}