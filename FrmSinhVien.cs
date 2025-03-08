using System.Data.SqlClient;
using System.Data;

namespace BTLWinform
{
    public partial class FrmSinhVien : Form
    {
        private int maSinhVien = 1;
        public FrmSinhVien()
        {
            InitializeComponent();
        }


        private void btnLichHoc_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Lịch học";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_LichHoc());
        }

        private void btnThongTinCaNhan_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Thông tin cá nhân";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_ThongTinCaNhan());
        }
    }
}
