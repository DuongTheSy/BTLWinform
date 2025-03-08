namespace BTLWinform
{
    partial class FrmSinhVien
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelMenu = new Panel();
            btnDoiMatKhau = new Button();
            btnLichHoc = new Button();
            btnDangKyMon = new Button();
            btnThongTinCaNhan = new Button();
            btnDangXuat = new Button();
            panelContent = new Panel();
            lblTitle = new Label();
            pnContent = new Panel();
            panelMenu.SuspendLayout();
            panelContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelMenu
            // 
            panelMenu.BackColor = Color.FromArgb(41, 128, 185);
            panelMenu.Controls.Add(btnDoiMatKhau);
            panelMenu.Controls.Add(btnLichHoc);
            panelMenu.Controls.Add(btnDangKyMon);
            panelMenu.Controls.Add(btnThongTinCaNhan);
            panelMenu.Controls.Add(btnDangXuat);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(220, 688);
            panelMenu.TabIndex = 1;
            // 
            // btnDoiMatKhau
            // 
            btnDoiMatKhau.Dock = DockStyle.Bottom;
            btnDoiMatKhau.FlatStyle = FlatStyle.Flat;
            btnDoiMatKhau.ForeColor = Color.White;
            btnDoiMatKhau.Location = new Point(0, 588);
            btnDoiMatKhau.Name = "btnDoiMatKhau";
            btnDoiMatKhau.Size = new Size(220, 50);
            btnDoiMatKhau.TabIndex = 4;
            btnDoiMatKhau.Text = "Đổi mật khẩu";
            // 
            // btnLichHoc
            // 
            btnLichHoc.Dock = DockStyle.Top;
            btnLichHoc.FlatStyle = FlatStyle.Flat;
            btnLichHoc.ForeColor = Color.White;
            btnLichHoc.Location = new Point(0, 100);
            btnLichHoc.Name = "btnLichHoc";
            btnLichHoc.Size = new Size(220, 50);
            btnLichHoc.TabIndex = 0;
            btnLichHoc.Text = "Lịch học";
            btnLichHoc.Click += btnLichHoc_Click_1;
            // 
            // btnDangKyMon
            // 
            btnDangKyMon.Dock = DockStyle.Top;
            btnDangKyMon.FlatStyle = FlatStyle.Flat;
            btnDangKyMon.ForeColor = Color.White;
            btnDangKyMon.Location = new Point(0, 50);
            btnDangKyMon.Name = "btnDangKyMon";
            btnDangKyMon.Size = new Size(220, 50);
            btnDangKyMon.TabIndex = 1;
            btnDangKyMon.Text = "Đăng ký môn";
            // 
            // btnThongTinCaNhan
            // 
            btnThongTinCaNhan.Dock = DockStyle.Top;
            btnThongTinCaNhan.FlatStyle = FlatStyle.Flat;
            btnThongTinCaNhan.ForeColor = Color.White;
            btnThongTinCaNhan.Location = new Point(0, 0);
            btnThongTinCaNhan.Name = "btnThongTinCaNhan";
            btnThongTinCaNhan.Size = new Size(220, 50);
            btnThongTinCaNhan.TabIndex = 2;
            btnThongTinCaNhan.Text = "Thông tin cá nhân";
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
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Top;
            lblTitle.Font = new Font("Arial", 16F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(970, 70);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Lịch học";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(0, 70);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(970, 618);
            pnContent.TabIndex = 1;
            // 
            // FrmSinhVien
            // 
            ClientSize = new Size(1190, 688);
            Controls.Add(panelContent);
            Controls.Add(panelMenu);
            Name = "FrmSinhVien";
            Text = "Giao diện Sinh Viên";
            panelMenu.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        private Panel panelMenu;
        private Button btnDangKyMon;
        private Button btnThongTinCaNhan;
        private Button btnDangXuat;
        private Panel panelContent;
        private Label lblTitle;
        #endregion

        private Button btnLichHoc;
        private Button btnDoiMatKhau;
        private Panel pnContent;
    }
}
