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
    public partial class Quanlytaikhoan : Form
    {
        DMTaiKhoan TK = new DMTaiKhoan();
        public Quanlytaikhoan()
        {
            InitializeComponent();
        }
        void Taikhoan()
        {
            try
            {
                gridTaikhoan.DataSource = TK.Laytaikhoan();
            }
            catch
            {
                MessageBox.Show("Không lấy được dữ liệu từ bảng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Quanlytaikhoan_Load(object sender, EventArgs e)
        {
            Taikhoan();
        }

        private void tsbRef_Click(object sender, EventArgs e)
        {
            Taikhoan();
        }

        private void tsbThem_Click(object sender, EventArgs e)
        {
            Quanlytaikhoan1 frm = new Quanlytaikhoan1();
            frm.ShowDialog();
            Taikhoan();
        }

        private void tsbxoa_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult TRALOI;
                TRALOI = MessageBox.Show("Bạn muốn xóa phiếu bảo hành này?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (TRALOI == DialogResult.Yes)
                {
                    string STRMABH = gridView1.GetRowCellValue(gridView1.FocusedRowHandle, "TAIKHOAN").ToString();
                    TK.Xoataikhoan(STRMABH);
                    Taikhoan();
                    MessageBox.Show("Tài khoản đã được xóa", "Thông báo");
                }
            }
            catch
            {
                MessageBox.Show("Không xóa được tài khoản này.", "Lỗi");
            }
        }
    }
}
