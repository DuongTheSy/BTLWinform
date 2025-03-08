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
    public partial class UC_ThongTinCaNhan : UserControl
    {
        private int maSinhVien;
        public UC_ThongTinCaNhan(int ma)
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            maSinhVien = ma;
            LoadData();
        }

        private void LoadData()
        {
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            string query = $"SELECT * FROM SinhVien Where MaSV = {maSinhVien}";
            DataTable dt = dungChung.GetDataTable(query);
            foreach (DataRow row in dt.Rows)
            {
                txtMa.Text = row["MaSV"].ToString();
                txtTen.Text = row["HoTen"].ToString();
                dNgaySinh.Text = Convert.ToDateTime(row["NgaySinh"]).ToString();
                if (row["GioiTinh"].ToString() == "Nam")
                {
                    rdNam.Checked = true;
                    rdNu.Checked = false;
                }
                else { 
                    rdNam.Checked = false; 
                    rdNu.Checked = true;
                }
                txtEmail.Text = row["Email"].ToString();
                txtSDT.Text = row["SDT"].ToString();
                txtDiaChi.Text = row["DiaChi"].ToString();
            }
            dungChung.CloseConnection();
        }
    }
}
