using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BAL;

namespace QLCHDienThoaiDiDong
{
    public partial class Doimatkhau : Form
    {
        DMdoimatkhau MK = new DMdoimatkhau();
        public Doimatkhau()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Doimatkhau_Load(object sender, EventArgs e)
        {
            txttaikhoan.Focus();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            if (txttaikhoan.Text=="" || txtMKcu.Text == "" || txtmkmoi.Text == "" || txtxacnhan.Text == "")
                MessageBox.Show("Bạn phải nhập đầy đủ thông tin để thay đổi mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else if(txtmkmoi.Text != txtxacnhan.Text)
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không trùng khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
            {
                try
                {
                    griddn.DataSource = MK.LayDN(txttaikhoan.Text,txtMKcu.Text);
                    int dem = int.Parse(gridView1.RowCount.ToString());
                    if (dem == 1)
                    {
                        MK.Capnhatmatkhau(txttaikhoan.Text, txtMKcu.Text, txtmkmoi.Text);
                        MessageBox.Show("Đổi mật khẩu mới thành công", "Thông báo");
                    }
                    else
                    {
                        MessageBox.Show("Tên tài khoản hoặc mật khẩu không đúng.", "Thông báo");
                    }
                }
                catch
                {
                    MessageBox.Show("Không đổi được mật khẩu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
