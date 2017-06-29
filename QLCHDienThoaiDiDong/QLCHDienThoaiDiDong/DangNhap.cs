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
    public partial class DangNhap : Form
    {
        DMdoimatkhau dn = new DMdoimatkhau();
        DMTaiKhoan TK = new DMTaiKhoan();
        public DangNhap()
        {
            InitializeComponent();
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            gridDN.DataSource = TK.Laytaikhoan();
        }
        public string TAIKHOAN { set; get; }
        public string MAQUYEN { set; get; }
        private void btndangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                gridDN.DataSource = dn.LayDN(txtTaikhoan.Text,txtmatkhau.Text);
                TAIKHOAN = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN").ToString();
                MAQUYEN =(gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "MAQUYEN").ToString());
                int dem = 0;
                dem = int.Parse(gridView1.RowCount.ToString());
                if (dem != 0)
                {
                    this.Close();
                }
                else
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Tên tài khoản hoặc mật khẩu không hợp lệ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

    }
}
