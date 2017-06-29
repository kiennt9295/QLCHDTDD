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
    public partial class PhieuThu1 : Form
    {
        DMPhieuThu PT = new DMPhieuThu();
        public PhieuThu1()
        {
            InitializeComponent();
        }
        public string MAPT { set; get; }
        public string LYDOTHU { set; get; }
        public string NGUOINOPTIEN { set; get; }
        public string SOTIEN { set; get; }
        public string GHICHU { set; get; }
        public string NGAY { set; get; }
        public bool THEM { set; get; }
        private void PhieuThu1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            txtMapt.Text = MAPT;
            txtlydothu.Text = LYDOTHU;
            lueNguoinop.Text = NGUOINOPTIEN;
            txtsotien.Text = SOTIEN;
            txtGhichu.Text = GHICHU;
            dtpNgay.Text = NGAY;
        }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM)
            {
                try
                {
                    PT.ThemPhieuThu(int.Parse(txtMapt.Text.Trim()), txtlydothu.Text.Trim(), int.Parse(lueNguoinop.Text.Trim()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Thêm phiếu thu mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu thu", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM)
            {
                try
                {
                    PT.CapNhatPhieuThu(int.Parse(txtMapt.Text.Trim()), txtlydothu.Text.Trim(), int.Parse(lueNguoinop.Text.Trim()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Đã cập nhật phiếu thu mới", "Thông báo");
                }
                catch
                {
                    MessageBox.Show("Không cập nhật được phiếu thu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if(DEM==true)
            {
                int DEM2 = int.Parse(txtMapt.Text) + 1;
                txtMapt.Text = DEM2.ToString();
                DEM = false;
            }
            txtlydothu.ResetText();
            txtGhichu.ResetText();
            lueNguoinop.ResetText();
            txtsotien.ResetText();
            txtlydothu.Focus();
        }

        private void lueNguoinop_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind==DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueNguoinop.EditValue = null;
                lueNguoinop.Properties.NullText = "";
            }
        }
    }
}
