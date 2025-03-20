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
    }
}
