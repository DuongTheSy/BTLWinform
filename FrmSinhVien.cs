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
            LoadLichHoc();
        }


        private void btnLichHoc_Click_1(object sender, EventArgs e)
        {
            lblTitle.Text = "Lịch học 1";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_LichHoc());
        }
        private void LoadLichHoc()
        {
            //DungChung dungChung = new DungChung();
            //dungChung.OpenConnection();
            //string query = @"SELECT mh.TenMH, mh.SoTinChi, ltc.HocKy, ltc.NamHoc, ltc.BuoiHoc
            //                     FROM DangKy dk
            //                     JOIN LopTinChi ltc ON dk.MaLTC = ltc.MaLTC
            //                     JOIN MonHoc mh ON ltc.MaMH = mh.MaMH
            //                     WHERE dk.MaSV = 1";
            //dungChung.LoadDataToGridView(query, dataGridView1);
            //dungChung.CloseConnection();
        
        }
    }
}
