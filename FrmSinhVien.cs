using System.Data.SqlClient;
using System.Data;

namespace BTLWinform
{
    public partial class FrmSinhVien : Form
    {
        private int maSinhVien;
        public FrmSinhVien(int ma)
        {
            InitializeComponent();
            maSinhVien = ma;
        }


        private void btnLichHoc_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Lịch học";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_LichHoc(maSinhVien));
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_ThongTinCaNhan(maSinhVien));
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn đăng xuất?", "Xác nhận",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.Show();
            }
        }
    }
}
