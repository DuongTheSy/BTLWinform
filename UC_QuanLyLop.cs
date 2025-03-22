using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace BTLWinform
{
    public partial class UC_QuanLyLop : UserControl
    {
        private DungChung dungChung = new DungChung();

        public UC_QuanLyLop()
        {
            InitializeComponent();
            LoadSubjectData();
            LoadTeacherData();
            LoadRoom();
            LoadDataGridView();
        }

        private void LoadDataGridView()
        {
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            string query = $"SELECT LTC.MALTC, MH.TenMH, GV.HoTen, LTC.BuoiHoc, LTC.NgayBatDau, LTC.NgayKetThuc, LTC.PhongHoc " +
                           $"FROM BTL.dbo.LopTinChi LTC " +
                           $"JOIN BTL.dbo.MonHoc MH ON LTC.IDMH = MH.ID " +
                           $"JOIN BTL.dbo.GiangVien GV ON LTC.IDGV = GV.ID " +
                           $"ORDER BY LTC.PhongHoc;";

            DataTable dt = dungChung.GetDataTable(query);
            foreach (DataRow dr in dt.Rows)
            {
                dataGridView1.Rows.Add(dr["MALTC"], dr["TenMH"], dr["HoTen"], dr["BuoiHoc"], Convert.ToDateTime(dr["NgayBatDau"]).ToShortDateString(),
                                       Convert.ToDateTime(dr["NgayKetThuc"]).ToShortDateString(), dr["PhongHoc"]
                                       );
            }
            dungChung.CloseConnection();
        }

        private void LoadRoom()
        {
            List<string> rooms = new List<string>
            {
                "P21", "P22", "P23", "P24", "P31", "P32", "P33", "P34", "P41", "P42", "P43", "P44", "P51", "P52"
            };
            foreach (var room in rooms)
            {
                cboPhongHoc.Items.Add(room);
            }
        }

        private void LoadSubjectData()
        {
            //dungChung.OpenConnection();
            string query = "SELECT ID, TenMH FROM BTL.dbo.MonHoc;";
            DataTable data = dungChung.GetDataTable(query);
            data.Columns.Add("DisplayText", typeof(string), "TenMH");
            cboMonHoc.DataSource = data;
            cboMonHoc.DisplayMember = "DisplayText";
            cboMonHoc.ValueMember = "ID";
            //dungChung.CloseConnection();
        }

        private void LoadTeacherData()
        {
            DungChung dungChung = new DungChung();
            //dungChung.OpenConnection();
            string query = "SELECT ID, HoTen FROM BTL.dbo.GiangVien;";
            DataTable data = dungChung.GetDataTable(query);
            data.Columns.Add("DisplayText", typeof(string), "HoTen");
            cboGiangVien.DataSource = data;
            cboGiangVien.DisplayMember = "DisplayText";
            cboGiangVien.ValueMember = "ID";
            //dungChung.CloseConnection();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        static List<Tuple<string, DateTime>> GetDatesInRange(DateTime start, DateTime end, List<Tuple<string, DayOfWeek>> selectedDays)
        {
            List<Tuple<string, DateTime>> dates = new List<Tuple<string, DateTime>>();
            foreach (var item in selectedDays)
            {
                for (DateTime date = start; date <= end; date = date.AddDays(1))
                {
                    if (item.Item2 == date.DayOfWeek)
                    {
                        dates.Add(Tuple.Create(item.Item1, date.Date));
                    }
                }
            }
            return dates;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {

            List<string> ngayHoc = new List<string>();
            DateTime startDate = dateBatDau.Value;
            DateTime endDate = dateKetThuc.Value;
            List<Tuple<string, DayOfWeek>> schedule = new List<Tuple<string, DayOfWeek>>();
            foreach (string item in clLichHoc.CheckedItems)
            {
                if (item.Contains('2'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Monday));
                }
                else if (item.Contains('3'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Tuesday));
                }
                else if (item.Contains('4'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Wednesday));
                }
                else if (item.Contains('5'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Thursday));
                }
                else if (item.Contains('6'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Friday));
                }
                else if (item.Contains('7'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Saturday));
                }
            }
            List<Tuple<string, DateTime>> dates = GetDatesInRange(startDate, endDate, schedule);


            using (SqlConnection conn = new SqlConnection(dungChung.getConnectionString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("", conn, transaction))
                    {
                        cmd.CommandText = "INSERT INTO BTL.dbo.LopTinChi (MaLTC, IDMH, IDGV, HocKy, NamHoc, NgayBatDau, NgayKetThuc, BuoiHoc, PhongHoc) VALUES (@maLTC, @iDMH, @iDGV, @hocKy, @namHoc, @ngayBatDau, @ngayKetThuc, @buoiHoc, @phongHoc)";
                        cmd.Parameters.AddWithValue("@maLTC", txtMaLop.Text);
                        cmd.Parameters.AddWithValue("@iDMH", cboMonHoc.SelectedValue);
                        cmd.Parameters.AddWithValue("@iDGV", cboGiangVien.SelectedValue);
                        cmd.Parameters.AddWithValue("@hocKy", "1");
                        cmd.Parameters.AddWithValue("@namHoc", "2024-2025");
                        cmd.Parameters.AddWithValue("@ngayBatDau", startDate);
                        cmd.Parameters.AddWithValue("@ngayKetThuc", endDate);
                        cmd.Parameters.AddWithValue("@buoiHoc", string.Join(", ", schedule));
                        cmd.Parameters.AddWithValue("@phongHoc", cboPhongHoc.SelectedItem);
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO BTL.dbo.LichHoc (LopID, BuoiHoc, NgayHoc, PhongHoc) VALUES (@lopId, @buoiHoc1, @ngayHoc1, @phongHoc1)";
                        cmd.Parameters.Add("@lopId", SqlDbType.VarChar);
                        cmd.Parameters.Add("@buoiHoc1", SqlDbType.VarChar);
                        cmd.Parameters.Add("@ngayHoc1", SqlDbType.VarChar);
                        cmd.Parameters.Add("@phongHoc1", SqlDbType.NVarChar);

                        foreach (var date in dates)
                        {
                            cmd.Parameters["@lopId"].Value = txtMaLop.Text;
                            cmd.Parameters["@buoiHoc1"].Value = date.Item1;
                            cmd.Parameters["@ngayHoc1"].Value = date.Item2;
                            cmd.Parameters["@phongHoc1"].Value = cboPhongHoc.SelectedItem;

                            cmd.ExecuteNonQuery();
                        }
                    }

                    transaction.Commit();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            btnLamMoi.PerformClick();
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            LoadDataGridView();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một lớp tín chỉ để sửa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            List<string> ngayHoc = new List<string>();
            DateTime startDate = dateBatDau.Value;
            DateTime endDate = dateKetThuc.Value;
            List<Tuple<string, DayOfWeek>> schedule = new List<Tuple<string, DayOfWeek>>();
            foreach (string item in clLichHoc.CheckedItems)
            {
                if (item.Contains('2'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Monday));
                }
                else if (item.Contains('3'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Tuesday));
                }
                else if (item.Contains('4'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Wednesday));
                }
                else if (item.Contains('5'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Thursday));
                }
                else if (item.Contains('6'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Friday));
                }
                else if (item.Contains('7'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Saturday));
                }
            }
            List<Tuple<string, DateTime>> dates = GetDatesInRange(startDate, endDate, schedule);


            using (SqlConnection conn = new SqlConnection(dungChung.getConnectionString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("", conn, transaction))
                    {
                        string query = @"
                        UPDATE LopTinChi 
                        SET IDMH = (SELECT IDMH FROM MonHoc WHERE TenMH = @TenMon),
                            IDGV = (SELECT IDGV FROM GiangVien WHERE HoTen = @HoTen),
                            HocKy = @HocKy, 
                            NamHoc = @NamHoc, 
                            NgayBatDau = @NgayBatDau, 
                            NgayKetThuc = @NgayKetThuc, 
                            BuoiHoc = @BuoiHoc, 
                            PhongHoc = @PhongHoc
                        WHERE MaLTC = @MaLTC;";

                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@MaLTC", txtMaLop.Text);
                        cmd.Parameters.AddWithValue("@TenMon", cboMonHoc.Text);
                        cmd.Parameters.AddWithValue("@HoTen", cboGiangVien.Text);
                        cmd.Parameters.AddWithValue("@HocKy", "1");
                        cmd.Parameters.AddWithValue("@NamHoc", "2024-2025");
                        cmd.Parameters.AddWithValue("@NgayBatDau", startDate);
                        cmd.Parameters.AddWithValue("@NgayKetThuc", endDate);
                        cmd.Parameters.AddWithValue("@BuoiHoc", string.Join(", ", schedule));

                        cmd.Parameters.AddWithValue("@phongHoc", cboPhongHoc.SelectedItem);
                        cmd.ExecuteNonQuery();

                    }

                    transaction.Commit();
                    MessageBox.Show("Thêm dữ liệu thành công!");
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            btnLamMoi.PerformClick();
        }

        private string ConvertLichHoc(string rawData)
        {
            rawData = rawData.Trim('(', ')');
            string[] parts = rawData.Split(',');

            if (parts.Length == 2)
            {
                string buoi = parts[0].Trim();
                string ngay = parts[1].Trim();
                Dictionary<string, string> ngayMapping = new Dictionary<string, string>()
                    {
                        {"Monday", "thứ 2"},
                        {"Tuesday", "thứ 3"},
                        {"Wednesday", "thứ 4"},
                        {"Thursday", "thứ 5"},
                        {"Friday", "thứ 6"},
                        {"Saturday", "thứ 7"},
                        {"Sunday", "Chủ nhật"}
                    };

                if (ngayMapping.ContainsKey(ngay))
                {
                    ngay = ngayMapping[ngay];
                }

                string lichHoc = $"{buoi} {ngay}";
                return lichHoc;
            }
            return "NULL";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                txtMaLop.Text = row.Cells[0].Value.ToString();
                cboMonHoc.SelectedIndex = cboMonHoc.FindStringExact(row.Cells[1].Value.ToString());

                cboGiangVien.SelectedIndex = cboGiangVien.FindStringExact(row.Cells[2].Value.ToString());
                dateBatDau.Value = Convert.ToDateTime(row.Cells[4].Value);
                dateKetThuc.Value = Convert.ToDateTime(row.Cells[5].Value);
                cboPhongHoc.SelectedIndex = cboPhongHoc.FindStringExact(row.Cells[6].Value.ToString());
                //if (row.Cells[5].Value != null)
                //{
                //    string phongHoc = row.Cells[5].Value.ToString().Trim();
                //    int index = cboPhongHoc.FindStringExact(phongHoc);

                //    if (index != -1) // Nếu tìm thấy phòng trong danh sách
                //    {
                //        cboPhongHoc.SelectedIndex = index;
                //    }
                //    else
                //    {
                //        MessageBox.Show($"Phòng '{phongHoc}' không có trong danh sách!");
                //    }
                //}

                string lichHoc = ConvertLichHoc(row.Cells[3].Value.ToString());
                for (int i = 0; i < clLichHoc.Items.Count; i++)
                {
                    clLichHoc.SetItemChecked(i, false);
                }

                for (int i = 0; i < clLichHoc.Items.Count; i++)
                {

                    if (clLichHoc.Items[i].ToString() == lichHoc)
                    {
                        clLichHoc.SetItemChecked(i, true);
                    }
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = txtMaLop.Text;

            if (id == "")
            {
                MessageBox.Show("Vui lòng chọn lớp tín chỉ cần xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn xóa lớp tín chỉ này?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DungChung dungchung = new DungChung();
                dungchung.OpenConnection();

                string query = "DELETE FROM LopTinChi WHERE MaLTC = @MaLTC ";

                SqlParameter[] parameters = {
                    new SqlParameter("@MaLTC", txtMaLop.Text)
                };

                int result_cmd = dungchung.ExecuteNonQuery(query, parameters);
                if (result_cmd > 0)
                {
                    MessageBox.Show("Xóa lớp tín chỉ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLamMoi.PerformClick();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lớp tín chỉ cần xóa!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                dungchung.CloseConnection();
            }
        }
    }
}
