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
    public partial class PhieuChi : Form
    {
        DMPhieuChi pc = new DMPhieuChi();
        public PhieuChi()
        {
            InitializeComponent();
        }
        public string MAPC { set; get; }
        public string LYDOCHI { set; get; }
        public string NGUOINHAN { set; get; }
        public string SOTIEN1 { set; get; }
        public string GHICHU1 { set; get; }
        public string NGAY1 { set; get; }
        public bool THEM1 { set; get; }
        private void PhieuChi_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLCHDienThoaiDDDataSet5.NHANVIEN' table. You can move, or remove it, as needed.
            //this.nHANVIENTableAdapter.Fill(this.qLCHDienThoaiDDDataSet5.NHANVIEN);
            
            txtMapc.Text = MAPC;
            txtlydochi.Text = LYDOCHI;
            lueNguoinhan.Text = NGUOINHAN;
            txtsotien.Text = SOTIEN1;
            dtpNgay.Text = NGAY1;
            txtGhichu.Text = GHICHU1;
        }
        public bool DEM { set; get; }
        private void btnluu_Click(object sender, EventArgs e)
        {
            if (THEM1)
            {
                try
                {
                    pc.ThemPhieuChi(int.Parse(txtMapc.Text.Trim()), txtlydochi.Text.Trim(), int.Parse(lueNguoinhan.Text.Trim()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
                    MessageBox.Show("Thêm phiếu chi mới thành công", "Thông báo");
                    DEM = true;
                }
                catch
                {
                    MessageBox.Show("Không thêm được phiếu chi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            if (!THEM1)
            {
                try
                {
                    pc.CapNhatPhieuChi(int.Parse(txtMapc.Text.Trim()), txtlydochi.Text.Trim(), int.Parse(lueNguoinhan.Text.Trim()), float.Parse(txtsotien.Text.Trim()), DateTime.Parse(dtpNgay.Text.Trim()), txtGhichu.Text.Trim());
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
                int DEM2 = int.Parse(txtMapc.Text) + 1;
                txtMapc.Text = DEM2.ToString();
                DEM = false;
            }
            txtlydochi.ResetText();
            txtGhichu.ResetText();
            txtsotien.ResetText();
            lueNguoinhan.ResetText();
            txtlydochi.Focus();
        }

        private void lueNguoinhan_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind== DevExpress.XtraEditors.Controls.ButtonPredefines.Delete)
            {
                lueNguoinhan.EditValue = null;
                lueNguoinhan.Properties.NullText = "";
            }
        }
    }
}
