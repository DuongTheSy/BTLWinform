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
    public partial class UC_LichHoc : UserControl
    {
        private int maSinhVien;
        public UC_LichHoc(int ma)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            maSinhVien = ma;
            LoadLichHoc();
        }
        private void LoadLichHoc()
        {
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            string query = $@"SELECT mh.TenMH , mh.SoTinChi, ltc.HocKy, ltc.NamHoc, gv.HoTen AS GiangVien, 
                        DATENAME(WEEKDAY, ltc.NgayBatDau) AS ThuMay, ltc.BuoiHoc 
                 FROM DangKy dk
                 JOIN LopTinChi ltc ON dk.MaLTC = ltc.MaLTC
                 JOIN MonHoc mh ON ltc.MaMH = mh.MaMH
                 JOIN GiangVien gv ON ltc.MaGV = gv.MaGV
                 WHERE dk.MaSV = {maSinhVien}
                 ORDER BY ThuMay";

            DataTable dt = dungChung.GetDataTable(query);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["TenMH"], dr["SoTinChi"], dr["HocKy"],
                                       dr["NamHoc"], dr["GiangVien"], dr["ThuMay"], dr["BuoiHoc"]
                                       );
            }
            dungChung.CloseConnection();
        }
    }
}
