using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWinform
{
    public partial class UC_DangKyMon : UserControl
    {
        public UC_DangKyMon()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            LoadDangKyMon();
        }
        private void LoadDangKyMon()
        {
            string query = "";
            DungChung dungchung = new DungChung();
            dungchung.OpenConnection();
            query = "SELECT ltc.MaLTC, mh.TenMH, mh.SoTinChi, ltc.HocKy, ltc.NamHoc, gv.HoTen AS GiangVien, ltc.BuoiHoc " +
                               "FROM LopTinChi ltc " +
                               "JOIN MonHoc mh ON ltc.MaMH = mh.MaMH " +
                               "LEFT JOIN GiangVien gv ON ltc.MaGV = gv.MaGV";
            dungchung.LoadDataToGridView(query,dgvLopTinChi);
        }
    }
}
