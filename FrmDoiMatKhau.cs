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
    public partial class FrmDoiMatKhau : Form
    {
        public FrmDoiMatKhau()
        {
            InitializeComponent();
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

        }
    }
}
