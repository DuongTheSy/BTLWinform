using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTLWinform
{
    public partial class UC_QuanLyMonHoc : UserControl
    {
        public UC_QuanLyMonHoc()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            LoadData();
        }

        private void LoadData()
        {
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            string query = $"SELECT * FROM MonHoc ";

            DataTable dt = dungChung.GetDataTable(query);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["ID"], dr["MaMonHoc"], dr["TenMH"],
                                       dr["SoTinChi"]
                                       );
            }
            dungChung.CloseConnection();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MonHoc (TenMH, SoTinChi, MaMonHoc) " +
                           "VALUES (@TenMH, @SoTinChi, @MaMonHoc)";

            SqlParameter[] parameters = {
                new SqlParameter("@TenMH", txtMonHoc.Text),
                new SqlParameter("@MaMonHoc", txtMaMonHoc.Text),
                new SqlParameter("@SoTinChi", txtSoTinChi.Text),
            };

            DungChung dungchung = new DungChung();
            int result = dungchung.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Không thể thêm môn học!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DungChung dungchung = new DungChung();
            dungchung.OpenConnection();

            string query = "UPDATE MonHoc SET MaMonHoc = @MaMonHoc, TenMH = @TenMH, SoTinChi = @SoTinChi WHERE ID = @ID";

            SqlParameter[] parameters = {
                new SqlParameter("@ID", txtID.Text),
                new SqlParameter("@MaMonHoc", txtMaMonHoc.Text),
                new SqlParameter("@TenMH", txtMonHoc.Text),
                new SqlParameter("@SoTinChi", txtSoTinChi.Text)
            };
            int result = dungchung.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Không tìm thấy môn học để cập nhật.");
            }

            dungchung.CloseConnection();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtMaMonHoc.Text = row.Cells[1].Value.ToString();
                txtMonHoc.Text = row.Cells[2].Value.ToString();
                txtSoTinChi.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn môn học cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa môn học này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DungChung dungchung = new DungChung();
                dungchung.OpenConnection();

                string query = "DELETE FROM MonHoc WHERE ID = @ID ";

                SqlParameter[] parameters = {
                    new SqlParameter("@ID", txtID.Text)
                };

                int result_cmd = dungchung.ExecuteNonQuery(query, parameters);
                if (result_cmd > 0)
                {
                    MessageBox.Show("Xóa môn học thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy môn học cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dungchung.CloseConnection();
            }
        }
    }
}
