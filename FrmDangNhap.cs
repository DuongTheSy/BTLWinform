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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            int maNguoiDung = 0;
            string taiKhoan = txtTaiKhoan.Text;
            string matKhau = txtMatKhau.Text;
            string vaiTro = "";
            string query = "";
            string ma = "";

            if (rdoSinhVien.Checked)
            {
                vaiTro = "SinhVien";
                ma = "MaSV";
            }
            if (rdoGiangVien.Checked)
            {
                vaiTro = "GiangVien";
                ma = "MaGV";
            }

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            query = $"SELECT {ma} FROM {vaiTro} WHERE TenDangNhap = '{taiKhoan}' AND MatKhau = '{matKhau}'";
            maNguoiDung = dungChung.ExecuteScalar(query);
            System.Diagnostics.Debug.WriteLine(maNguoiDung);
            if (maNguoiDung != 0)
            {
                System.Diagnostics.Debug.WriteLine(vaiTro);
                FrmSinhVien frmSinhVien = new FrmSinhVien(maNguoiDung, vaiTro);
                this.Hide();
                frmSinhVien.Show();
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dungChung.CloseConnection();

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
        }
    }
}
