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
        }

        private void LoadRoom()
        {
            List<string> rooms = new List<string>
            {
                "P21", "P22", "P23", "P24", "P31", "P32", "P33", "P34", "P41", "P42", "P43", "P44", "P51", "P52"
            };
            foreach(var room in rooms)
            {
                comboBox3.Items.Add(room);
            }
        }

        private void LoadSubjectData()
        {
            //dungChung.OpenConnection();
            string query = "SELECT ID, TenMH FROM BTL.dbo.MonHoc;";
            DataTable data = dungChung.GetDataTable(query);
            data.Columns.Add("DisplayText", typeof(string), "ID + ' - ' + TenMH");
            comboBox1.DataSource = data;
            comboBox1.DisplayMember = "DisplayText";
            comboBox1.ValueMember = "ID";
            //dungChung.CloseConnection();
        }

        private void LoadTeacherData()
        {
            DungChung dungChung = new DungChung();
            //dungChung.OpenConnection();
            string query = "SELECT ID, HoTen FROM BTL.dbo.GiangVien;";
            DataTable data = dungChung.GetDataTable(query);
            data.Columns.Add("DisplayText", typeof(string), "ID + ' - ' + HoTen");
            comboBox2.DataSource = data;
            comboBox2.DisplayMember = "DisplayText";
            comboBox2.ValueMember = "ID";
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
            DateTime startDate = txtNgayBatDau.Value;
            DateTime endDate = txtNgayKetThuc.Value;
            List<Tuple<string, DayOfWeek>> schedule = new List<Tuple<string, DayOfWeek>>();
            foreach (string item in checkedListBox1.CheckedItems)
            {
                if (item.Contains('2'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Monday));
                } else if (item.Contains('3'))
                {
                    schedule.Add(Tuple.Create(item.Contains("Sáng") ? "Sáng" : "Chiều", DayOfWeek.Tuesday));
                } else if (item.Contains('4'))
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
            Debug.WriteLine($"data: {comboBox3.SelectedValue}, {string.Join(", ", schedule)}");


            using (SqlConnection conn = new SqlConnection(dungChung.getConnectionString()))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    using (SqlCommand cmd = new SqlCommand("", conn, transaction))
                    {
                        cmd.CommandText = "INSERT INTO BTL.dbo.LopTinChi (MaLTC, IDMH, IDGV, HocKy, NamHoc, NgayBatDau, NgayKetThuc, BuoiHoc, PhongHoc) VALUES (@maLTC, @iDMH, @iDGV, @hocKy, @namHoc, @ngayBatDau, @ngayKetThuc, @buoiHoc, @phongHoc)";
                        cmd.Parameters.AddWithValue("@maLTC", textBox1.Text);
                        cmd.Parameters.AddWithValue("@iDMH", comboBox1.SelectedValue);
                        cmd.Parameters.AddWithValue("@iDGV", comboBox2.SelectedValue);
                        cmd.Parameters.AddWithValue("@hocKy", "1");
                        cmd.Parameters.AddWithValue("@namHoc", "2024-2025");
                        cmd.Parameters.AddWithValue("@ngayBatDau", startDate);
                        cmd.Parameters.AddWithValue("@ngayKetThuc", endDate);
                        cmd.Parameters.AddWithValue("@buoiHoc", string.Join(", ", schedule));
                        cmd.Parameters.AddWithValue("@phongHoc", "P22");
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = "INSERT INTO BTL.dbo.LichHoc (LopID, BuoiHoc, NgayHoc, PhongHoc) VALUES (@lopId, @buoiHoc1, @ngayHoc1, @phongHoc1)";
                        cmd.Parameters.Add("@lopId", SqlDbType.VarChar);
                        cmd.Parameters.Add("@buoiHoc1", SqlDbType.VarChar);
                        cmd.Parameters.Add("@ngayHoc1", SqlDbType.VarChar);
                        cmd.Parameters.Add("@phongHoc1", SqlDbType.NVarChar);

                        foreach (var date in dates)
                        {
                            cmd.Parameters["@lopId"].Value = textBox1.Text;
                            cmd.Parameters["@buoiHoc1"].Value = date.Item1;
                            cmd.Parameters["@ngayHoc1"].Value = date.Item2;
                            cmd.Parameters["@phongHoc1"].Value = "P22";

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
        }
    }
}
