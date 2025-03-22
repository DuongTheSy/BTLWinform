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
    public partial class FrmDoiMatKhau : Form
    {
        private int masinhvien;
        public FrmDoiMatKhau(int maNguoiDung)
        {
            InitializeComponent();
            masinhvien = maNguoiDung;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string matkhaucu = txtOldPass.Text;
            string matkhaumoi = txtNewPass.Text;
            string xacnhanmatkhau = txtConfirmPass.Text;

            if(matkhaucu == "" || matkhaumoi == "" || xacnhanmatkhau == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if(matkhaumoi != xacnhanmatkhau)
            {
                MessageBox.Show("Mật khẩu mới không trùng khớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            DungChung dungChung = new DungChung();
            dungChung.OpenConnection();

            string query = "UPDATE SinhVien SET MatKhau = @MatKhauMoi WHERE ID = @UserID";


            System.Diagnostics.Debug.WriteLine(matkhaumoi + "  " + masinhvien);
            SqlParameter[] parameters = {
                new SqlParameter("@MatKhauMoi", matkhaumoi),
                new SqlParameter("@UserID", masinhvien),

            };
            int result = dungChung.ExecuteNonQuery(query, parameters);
            if (result > 0)
            {
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Đổi mật khẩu thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            dungChung.CloseConnection();

       
        }
    }
}
