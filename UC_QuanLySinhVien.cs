using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BTLWinform
{
    public partial class UC_QuanLySinhVien : UserControl
    {
        public UC_QuanLySinhVien()
        {
            InitializeComponent();
            Dock = DockStyle.Fill;
            LoadData();
        }

        private void LoadData()
        {
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            string query = $"SELECT ID, MaSV, HoTen, NgaySinh, GioiTinh, Email, SDT, DiaChi FROM SinhVien ";

            DataTable dt = dungChung.GetDataTable(query);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["ID"], dr["MaSV"], dr["HoTen"],
                                       dr["NgaySinh"], dr["GioiTinh"], dr["Email"], dr["SDT"], dr["DiaChi"]
                                       );
            }
            dungChung.CloseConnection();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            LoadData();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtID.Text = row.Cells[0].Value.ToString();
                txtMaSV.Text = row.Cells[1].Value.ToString();
                txtTenSV.Text = row.Cells[2].Value.ToString();
                txtNgaySinh.Value = (DateTime)dataGridView1.CurrentRow.Cells[3].Value;
                if (row.Cells[4].Value.ToString().Trim() == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txtEmail.Text = row.Cells[5].Value.ToString();
                txtSDT.Text = row.Cells[6].Value.ToString();
                txtDiaChi.Text = row.Cells[7].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO SinhVien (TenDangNhap, HoTen, NgaySinh, GioiTinh, Email, MatKhau, SDT, DiaChi, MaSV) " +
                           "VALUES (@TenDangNhap, @HoTen, @NgaySinh, @GioiTinh, @Email, @MatKhau, @SDT, @DiaChi, @MaSV)";

            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", txtMaSV.Text),
                new SqlParameter("@HoTen", txtTenSV.Text),
                new SqlParameter("@NgaySinh", txtNgaySinh.Value),
                new SqlParameter("@GioiTinh", rdNam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@MatKhau", "123456"),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@DiaChi", txtDiaChi.Text),
                new SqlParameter("@MaSV", txtMaSV.Text)
            };

            DungChung dungchung = new DungChung();
            int result = dungchung.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Không thể thêm sinh viên!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            DungChung dungchung = new DungChung();
            dungchung.OpenConnection();

            string query = "UPDATE SinhVien SET MaSV = @MaSV, TenDangNhap = @TenDangNhap, HoTen = @HoTen, NgaySinh = @NgaySinh, GioiTinh = @GioiTinh, Email = @Email, SDT = @SDT, DiaChi = @DiaChi WHERE ID = @ID";

            SqlParameter[] parameters = {
                new SqlParameter("@TenDangNhap", txtMaSV.Text),
                new SqlParameter("@HoTen", txtTenSV.Text),
                new SqlParameter("@NgaySinh", txtNgaySinh.Value),
                new SqlParameter("@GioiTinh", rdNam.Checked ? "Nam" : "Nữ"),
                new SqlParameter("@Email", txtEmail.Text),
                new SqlParameter("@SDT", txtSDT.Text),
                new SqlParameter("@DiaChi", txtDiaChi.Text),
                new SqlParameter("@MaSV", txtMaSV.Text),
                new SqlParameter("@ID", txtID.Text),

            };
            int result = dungchung.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Cập nhật thành công!");
                btnLamMoi.PerformClick();
            }
            else
            {
                MessageBox.Show("Không tìm thấy sinh viên để cập nhật.");
            }

            dungchung.CloseConnection();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;

            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn sinh viên cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa sinh viên này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DungChung dungchung = new DungChung();
                dungchung.OpenConnection();

                string query = "DELETE FROM SinhVien WHERE ID = @ID ";

                SqlParameter[] parameters = {
                    new SqlParameter("@ID", txtID.Text)
                };

                int result_cmd = dungchung.ExecuteNonQuery(query,parameters);
                if (result_cmd > 0)
                {
                    MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy sinh viên cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dungchung.CloseConnection();
            }
        }
    }
}
