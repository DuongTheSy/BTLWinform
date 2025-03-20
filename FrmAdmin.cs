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
    public partial class FrmAdmin : Form
    {
        public FrmAdmin()
        {
            InitializeComponent();
        }

        private void btnQuanLySinhVien_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý sinh viên";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_QuanLySinhVien());
        }

        private void btnQuanLyGiangVien_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý giảng viên";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_QuanLyGiangVien());
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "Quản lý môn học";
            pnContent.Controls.Clear();
            pnContent.Controls.Add(new UC_QuanLyMonHoc());
        }
    }
}
