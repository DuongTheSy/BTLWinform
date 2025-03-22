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
            string query = "";
            string ma = "";

            if (string.IsNullOrEmpty(taiKhoan) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập tài khoản và mật khẩu!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();
            query = $"SELECT MaAdmin FROM Admin WHERE TenDangNhap = '{taiKhoan}' AND MatKhau = '{matKhau}'";
            maNguoiDung = dungChung.ExecuteScalar(query);
            if (maNguoiDung != 0)
            {
                FrmAdmin frmAdmin = new FrmAdmin();
                this.Hide();
                frmAdmin.Show();
      
            }
            else
            {
                query = $"SELECT ID FROM SinhVien WHERE TenDangNhap = '{taiKhoan}' AND MatKhau = '{matKhau}'";
                maNguoiDung = dungChung.ExecuteScalar(query);
                if (maNguoiDung != 0)
                {
                    FrmSinhVien frmSinhVien = new FrmSinhVien(maNguoiDung);
                    System.Diagnostics.Debug.WriteLine(maNguoiDung + "abc");
                    this.Hide();
                    frmSinhVien.Show();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                dungChung.CloseConnection();
            }
        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            txtMatKhau.Text = "";
            txtTaiKhoan.Text = "";
        }
    }
}
