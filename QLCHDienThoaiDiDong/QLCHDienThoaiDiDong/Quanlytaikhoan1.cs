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
    public partial class Quanlytaikhoan1 : Form
    {
        DMTaiKhoan TK=new DMTaiKhoan();
        public Quanlytaikhoan1()
        {
            InitializeComponent();
        }
        private void Quanlytaikhoan1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet12.PHANQUYEN' table. You can move, or remove it, as needed.
            //this.pHANQUYENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet12.PHANQUYEN);
            
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
                try
                {
                    TK.Themtaikhoan(txttaikhoan.Text.Trim(),txtmatkhau.Text.Trim(),int.Parse(luemaquyen.Text.Trim()));
                    MessageBox.Show("Thêm tài khoản mới thành công", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không thêm được tài khoản", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }
    }
}
